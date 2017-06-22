using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemplePoso
{
	public partial class CircuitMedic : Form
	{
		private IVidalHelper helper;
		private int? ucdId;
		public CircuitMedic()
		{
			InitializeComponent();
		}

		public CircuitMedic(IVidalHelper helper, int? ucdId)
		{
			if (helper == null)
			{
				InitializeComponent();
			}
			InitializeComponent();
			this.helper = helper;
			this.ucdId = ucdId;
			initCircuit((int)ucdId);
			initCompo((int)ucdId);
		}

		private void initCompo(int p)
		{
			VidalAPI.Domain.ItemCompositionsCoupleList list = (VidalAPI.Domain.ItemCompositionsCoupleList)helper.compo(p);
			foreach (VidalAPI.Domain.ItemCompositionsCouple couple in list)
			{
				TreeNode item = new TreeNode();
				item.Text = couple.Item.FullName + " : " + couple.Item.Name;

				TreeNode molecPA = new TreeNode();
				molecPA.Text = "PrincipesActifs";
				TreeNode molecEEN = new TreeNode();
				molecEEN.Text = "Excipients à effts notoires";
				TreeNode molecE = new TreeNode();
				molecE.Text = "Excipients";
				TreeNode molec = new TreeNode();

				foreach (VidalAPI.Domain.Composition compo in couple.Compositions)
				{
					TreeNode name = new TreeNode();
					name.Text = compo.Molecule.Name;
					TreeNode detail = new TreeNode();
					detail.Text = compo.PerVolume + " " + compo.PerVolumeUnit;

					TreeNode detail2 = new TreeNode();
					detail2.Text = compo.Type.ToString();
					name.Nodes.Add(detail);
					name.Nodes.Add(detail2);

					if (compo.Type == VidalAPI.Domain.SubstanceType.SUBSTANCETYPE_ACTIVE_PRINCIPLE)
					{
						molecPA.Nodes.Add(name);
					}
					else if (compo.Type == VidalAPI.Domain.SubstanceType.SUBSTANCETYPE_ACTIVE_EXCIPIENT)
					{
						molecEEN.Nodes.Add(name);
					}
					else
					{
						molecE.Nodes.Add(name);
					}
				}
				item.Nodes.Add(molecPA);
				item.Nodes.Add(molecEEN);
				item.Nodes.Add(molecE);
				item.Nodes.Add(molec);
				treeViewCompo.Nodes.Add(item);
			}
		}

		private void initCircuit(int ucdId)
		{
			VidalAPI.Domain.UcdPosologyUnitsAndItemsConcentrationsList list = (VidalAPI.Domain.UcdPosologyUnitsAndItemsConcentrationsList)helper.circuitMedic(ucdId);
			TreeNode cm = new TreeNode();
			foreach (VidalAPI.Domain.UcdPosologyUnitsAndItemsConcentrations item in list)
			{
				label1.Text = item.Name;
				TreeNode ucd = new TreeNode();
				ucd.Name = item.Name;
				ucd.Text = item.Name;
				//todo rest of UCD
				TreeNode items = new TreeNode();
				items.Text = "items";

				//ADD UCDITEMS infos : composition et [c]
				foreach (VidalAPI.Domain.UcdItem itemUcd in item.UcdItems)
				{
					TreeNode itemUcdName = new TreeNode();
					itemUcdName.Text = itemUcd.FullName;
					TreeNode itemUcdFullName = new TreeNode();
					itemUcdFullName.Text = itemUcd.Name;
					itemUcdName.Nodes.Add(itemUcdFullName);
					TreeNode sub = new TreeNode();
					sub.Text = "ActiveSubstances";

					//ADD PA infos
					foreach (VidalAPI.Domain.ActiveSubstanceInformation pa in itemUcd.ActiveSubstanceInformations)
					{
						TreeNode itemUcdSub = new TreeNode();
						itemUcdSub.Text = pa.Molecule.Name;

						TreeNode itemUcdQunatity = new TreeNode();
						if (pa.Quantity != 0 && pa.QuantityUnit != null)
						{
							itemUcdQunatity.Text = "Quantity : " + pa.Quantity + " " + pa.QuantityUnit.Name;
						}
						else
						{
							itemUcdQunatity.Text = "Quantity : NC";
						}

						TreeNode itemUcdC = new TreeNode();
						if (pa.ConcentrationValue != 0 && pa.ConcentrationUnit != null)
						{
							itemUcdC.Text = "[c]: " + pa.ConcentrationValue + " " + pa.ConcentrationUnit.Name;
						}
						else
						{
							itemUcdC.Text = "[c]: NC";
						}
						itemUcdSub.Nodes.Add(itemUcdQunatity);
						itemUcdSub.Nodes.Add(itemUcdC);
						sub.Nodes.Add(itemUcdSub);
					}

					itemUcdName.Nodes.Add(sub);
					items.Nodes.Add(itemUcdName);

				}
				//ADD UCDITEMS Poso
				TreeNode poso = new TreeNode();
				poso.Text = "Posology";
				foreach (VidalAPI.Domain.UcdPosologyUnit unit in item.UcdPosologyUnits)
				{
					TreeNode posoLeaf = new TreeNode();
					posoLeaf.Text = "******";

					TreeNode dsipendingUnit = new TreeNode();
					if (unit != null && unit.DispensingUnit != null && unit.DispensingUnit.Name != null)
					{
						dsipendingUnit.Text = "Dispending Unit : " + unit.DispensingUnit.Name;
					}
					else
					{
						dsipendingUnit.Text = "Dispending Unit : NC";
					}
					posoLeaf.Nodes.Add(dsipendingUnit);

					TreeNode posoUnit = new TreeNode();
					if (unit.PosologyUnit.Name != null)
					{
						posoUnit.Text = "posoUnit : " + unit.PosologyUnit.Name;
					}
					else
					{
						posoUnit.Text = "posoUnit : NC";
					}
					posoLeaf.Nodes.Add(posoUnit);

					TreeNode ratio = new TreeNode();
					if (unit.RatioOfPosologyUnitOverDispensingUnit != 0)
					{
						ratio.Text = "ration : " + unit.RatioOfPosologyUnitOverDispensingUnit;
					}
					else
					{
						ratio.Text = "ration : NC";
					}
					posoLeaf.Nodes.Add(ratio);

					TreeNode quantity = new TreeNode();
					if (unit.UcdItemQuantity != 0 && unit.UcdItemQuantityUnit != null)
					{
						quantity.Text = "quantity : " + unit.UcdItemQuantity + " " + unit.UcdItemQuantityUnit;
					}
					else
					{
						quantity.Text = "quantity : NC";
					}

					posoLeaf.Nodes.Add(quantity);

					TreeNode volume = new TreeNode();
					if (unit.UcdItemVolume != 0 && unit.UcdItemVolumeUnit != null)
					{
						volume.Text = "volume : " + unit.UcdItemVolume + " " + unit.UcdItemVolumeUnit.Name;
					}
					else
					{
						volume.Text = "volume : NC";
					}
					posoLeaf.Nodes.Add(volume);

					poso.Nodes.Add(posoLeaf);
				};

				ucd.Nodes.Add(items);
				ucd.Nodes.Add(poso);
				cm.Nodes.Add(ucd);
				cm.ExpandAll();
			}

			treeViewCM.Nodes.Add(cm);
		}

		private void CircuitMedic_Load(object sender, EventArgs e)
		{
		}
	}
}
