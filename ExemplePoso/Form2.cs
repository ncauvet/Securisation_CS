using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ExemplePoso.dto;
using ExemplePoso.dto.poso;
using System.IO;
using System.Diagnostics;

namespace ExemplePoso
{
    public partial class FormEPPWS : Form
    {
       
        private static int GRID_COST = 0;
        private static int GRID_IAM = 1;
        private static int GRID_CI = 2;
        private static int GRID_PE = 3;
        private static int GRID_SUB = 4;
        private static int GRID_POSO = 5;
        private static int GRID_REDUNDANT = 7;
        private static int GRID_SURVEILLANCE = 8;
        private static int GRID_MEG = 9;
        private static int GRID_PCI = 6;
        private static int GRID_NAME = 10;

        public IVidalHelper helper;
        
        public FormEPPWS(IVidalHelper helper)
        {
            this.helper = helper;
            InitializeComponent();
            
     
            
            //Initialisation de la boîte de sélection des fréquence posologiques
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_2_DAYS);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_24_HOURS);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_DAY);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_HOUR);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_MINUTE);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_MONTH);
            //freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_N_HOURS);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_WEEK);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.PER_YEAR);
            freqComboBox.Items.Add(PosologyFrequencyTypeDto.THIS_DAY);
            //freqComboBox.Items.Add(PosologyFrequencyTypeDto.TYPE_44);
            //freqComboBox.Items.Add(PosologyFrequencyTypeDto.TYPE_46);
            //freqComboBox.Items.Add(PosologyFrequencyTypeDto.TYPE_66);
           // freqComboBox.Items.Add(null);
            
            freqComboBox.SelectedIndex = 2;

            //Initialisation de la boîte de sélection des durées
            dureeComboBox.Items.Add(DurationTypeDto.DAY);
            dureeComboBox.Items.Add(DurationTypeDto.HOUR);
            dureeComboBox.Items.Add(DurationTypeDto.MINUTE);
            dureeComboBox.Items.Add(DurationTypeDto.MONTH);
            dureeComboBox.Items.Add(DurationTypeDto.WEEK);
            dureeComboBox.Items.Add(DurationTypeDto.YEAR);
            dureeComboBox.Items.Add(DurationTypeDto.NULL);
        //    dureeComboBox.Items.Add(null);

            dureeComboBox.SelectedIndex = 0;

            //Initialisation de la boîte de ActiveDose
            activeDosecomboBox.Items.Add(DoseUnitDto.G);
            activeDosecomboBox.Items.Add(DoseUnitDto.KU);
            activeDosecomboBox.Items.Add(DoseUnitDto.MCG);
            activeDosecomboBox.Items.Add(DoseUnitDto.MG);
            activeDosecomboBox.Items.Add(DoseUnitDto.U);
            activeDosecomboBox.Items.Add(DoseUnitDto.MU);
            activeDosecomboBox.Items.Add(DoseUnitDto.ML);
            activeDosecomboBox.Items.Add(DoseUnitDto.MMOL);
           // activeDosecomboBox.Items.Add(null);

            activeDosecomboBox.SelectedIndex = 0;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (productButton.Checked)
            {
                List<ProductDto> result = helper.ProductService_searchByName(textBox1.Text);
                
                foreach (ProductDto product in result)
                {
                    listBox1.Items.Add(product);
                }
            }
            else if (vmpButton2.Checked)
            {
                List<CNGDto> result = helper.CngService_SearchByName(textBox1.Text);
                foreach (CNGDto cng in result)
                {
                    listBox1.Items.Add(cng);
                }
            }
            else if (packRadioButton.Checked)
            {
               List<PackDto> result = helper.PackService_searchByName(textBox1.Text);
                foreach (PackDto pack in result)
                {
                    listBox1.Items.Add(pack);
                }
            }
            else if (ucdRadioButton.Checked)
            {
                List<UcdDto> result = helper.UcdService_searchByName(textBox1.Text);
                foreach (UcdDto ucd in result)
                {
                    listBox1.Items.Add(ucd);
                }
            }
            else if (prescRadioButton.Checked)
            {
                List<BrandedPrescribableDto> result = helper.PrescribableService_searchBrandedPrescribableByName(textBox1.Text);
                foreach (BrandedPrescribableDto prescr in result)
                {
                    listBox1.Items.Add(prescr);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            drugSelecr();
        }

      

        private void initPosoForm(PosologyUnitDto unit, PosologyFrequencyTypeDto? type)
        {
            unitComboBox.Items.Add(unit);
            unitComboBox.SelectedIndex=0;
            freqComboBox.SelectedItem = type;
            
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> indications = new List<int>();
            List<int> routes = new List<int>();
            
            double dose = -1; 
            int unit = -1;
            String name="";
            DrugTypeDto type = DrugTypeDto.UNKNOWN;
            int id=0;
            if (productButton.Checked)
            {
                type = DrugTypeDto.PRODUCT;
                id = (int)((ProductDto)listBox1.SelectedItem).Id;
                name = ((ProductDto)listBox1.SelectedItem).Name;
            }
            else if (vmpButton2.Checked)
            {
                type = DrugTypeDto.COMMON_NAME_GROUP;
                id = (int)((CNGDto)listBox1.SelectedItem).Id;
                name = ((CNGDto)listBox1.SelectedItem).Name;
            }
            else if (packRadioButton.Checked)
            {
                type = DrugTypeDto.PACK;
                id = (int)((PackDto)listBox1.SelectedItem).Id;
                name = ((PackDto)listBox1.SelectedItem).Name;
            }
            else if (ucdRadioButton.Checked)
            {
                type = DrugTypeDto.UCD;
                id = (int)((UcdDto)listBox1.SelectedItem).Id;
                name = ((UcdDto)listBox1.SelectedItem).Name;
            }
            else if (prescRadioButton.Checked)
            {
                type = DrugTypeDto.BRANDED_PRESCRIBABLE;
                id = (int)((BrandedPrescribableDto)listBox1.SelectedItem).Id;
                name = ((BrandedPrescribableDto)listBox1.SelectedItem).Name;
            }

            PosologyFrequencyTypeDto freq = PosologyFrequencyTypeDto.PER_DAY;

            if(numericUpDown1.Visible)
            {
                dose = (double)numericUpDown1.Value;
            }
            if (unitComboBox.Visible && enDoseButton.Checked)
            {
                if ((PosologyUnitDto)unitComboBox.SelectedItem != null)
                {
                    unit = (int)((PosologyUnitDto)unitComboBox.SelectedItem).Id;
                }
                else
                {
                    unit = -1;
                }
            }
            if (freqComboBox.Visible)
            {
                freq = (PosologyFrequencyTypeDto)freqComboBox.SelectedItem;
            }

         
            //VidalAPI.Domain.PosologyAlerts result = vidalProduct.GetService<VidalAPI.Services.PosologyService>().CheckDailyDoseByProductId(((VidalAPI.Domain.Product)listBox1.SelectedItem).Id, dose, ((VidalAPI.Domain.PosologyUnit)unitComboBox.SelectedItem).Id, (VidalAPI.Domain.PosologyFrequencyType)freqComboBox.SelectedItem, (VidalAPI.Domain.Gender)genderBox.SelectedItem, 40f, (float)weightBox.Value, (int)heightBox.Value, (int)creatinBox.Value, (VidalAPI.Domain.HepaticInsufficiency)hepaticBox.SelectedItem, indications, routes);
           string prescrLine =  "";
           if (enDoseButton.Checked)
           {
               prescrLine = helper.AnalysisService_prescriptionLineInDosesFromObjToJson(
                   dose,
                   unit,
                   freq,
                   indications,
                   routes,
                   id,
                   type,
                   (int)dureeNumericUpDown.Value,
                   (DurationTypeDto)dureeComboBox.SelectedItem
                   );
           }
           else if(enPaButton.Checked){
               prescrLine = helper.AnalysisService_prescriptionLineInActivePrincipleDosesFromObjToJson(
                   dose,
                   (DoseUnitDto)activeDosecomboBox.SelectedItem,
                   freq,
                   indications,
                   routes,
                   id,
                   type,
                   (int)dureeNumericUpDown.Value,
                   (DurationTypeDto)dureeComboBox.SelectedItem
                   );
           }

           //string prescrLine2 = "{\"dose\":null,\"drug\":null,\"drugId\":15070,\"drugType\":\"PRODUCT\",\"frequencyType\":null,\"indicationIds\":null,\"posologyUnit\":null,\"routeIds\":[],\"unitId\":null}";

           dataGridView1.Rows.Add(null,null,null,null,null,null,null,null,null,null,name);
            
//           dataGridView1[GRID_NAME, (dataGridView1.Rows.Count + 1)].Value = name;
           dataGridView1.Rows[dataGridView1.Rows.Count -2].Cells[GRID_NAME].ToolTipText = prescrLine;

          analysePrescription();

        }

        private void resetForm()
        {
            treeView1.Nodes.Clear();
            unitComboBox.Items.Clear();
            freqComboBox.SelectedIndex = 0;
            indicListBox.Items.Clear();
            listBoxCI.Items.Clear();
            listBoxPE.Items.Clear();
           
        }

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            drugSelecr();
        }

        private void drugSelecr()
        {
            resetForm();
            //compute CI/PE
            int weight = -1;

            int creatin = -1;
            int weeks = -1;

            GenderDto? gender = null;
            BreastFeedingDto? breast = null;
            if (patientControl2.getBrestFeedingBoxChecked() == false)
            { breast = patientControl2.getBreastFeedingSelectedItem(); }
            
            if (patientControl2.getWeeksOfAmenoBoxChecked() == false)
            { weeks = patientControl2.getWeeksOfAmenValue(); }
            
            if (patientControl2.getPoidCheckBox() == false)
                {weight = patientControl2.getWeightBoxValue(); }

            if (patientControl2.getCreatinCheckBoxChecked() == false)
                {creatin = patientControl2.getCreatinBoxValue();}

            if (patientControl2.getGenderCheckBoxChecked() == false)
                {gender = patientControl2.getGenderBoxSelectedItem();}
            DateTime age = patientControl2.getMonthCalendar1SelectionStart();
                    
            if (listBox1.SelectedItem != null)
            {

                if (productButton.Checked)
                {
                    ProductDto product = ((ProductDto)listBox1.SelectedItem);
                    linkLabel1.Tag = product;
                    linkLabel1.Text = product.Name + " (liste :" + product.ListValue + ") (Remb: " + product.RefundingRateValue + ")";
                    if (product.DrugInSport) dopantPictureBox.Image = Resource1.dopingLarge;
                    else dopantPictureBox.Image = Resource1.dopingLargeOff;
                    if (product.SafetyAlert) withOutPictureBox.Image = Resource1.downloaded1;
                    else withOutPictureBox.Image = Resource1.withoutPrescriptionOff;
                    vigilanePictureBox.Image = ViewHelper.getVigilanceIcon(product);
                    genericPictureBox.Image = ViewHelper.getGenericIcon(product);
                    indicListBox.Items.AddRange(helper.getProductIndicator((int)product.Id).ToArray());
                    searchPosologieDescription((int)((ProductDto)listBox1.SelectedItem).Id);

                    listBoxCI.Items.AddRange(helper.searchCIAlert((int)product.Id,age,weight,BreastFeedingDto.NONE,0,creatin,GenderDto.MALE).ToArray<string>());
                    listBoxPE.Items.AddRange(helper.searchPEAlert((int)product.Id, age, weight, BreastFeedingDto.NONE, 0, creatin, GenderDto.MALE).ToArray<string>());
                }
                else if (vmpButton2.Checked)
                {
                    linkLabel1.Tag = (CNGDto)listBox1.SelectedItem;
                    linkLabel1.Text = ((CNGDto)listBox1.SelectedItem).Name;
                    initUnitNoPoso((int)((CNGDto)listBox1.SelectedItem).Id);
                    indicListBox.Items.AddRange(helper.getVMPIndicator((int)((CNGDto)listBox1.SelectedItem).Id).ToArray());

                }
                else if (ucdRadioButton.Checked)
                {
                    linkLabel1.Tag = (UcdDto)listBox1.SelectedItem;
                    linkLabel1.Text = ((UcdDto)listBox1.SelectedItem).Name;
                    ProductDto product = helper.ProductService_searchByUcdId((int)((UcdDto)listBox1.SelectedItem).Id);
                    if (product.DrugInSport) dopantPictureBox.Image = Resource1.dopingLarge;
                    if (((UcdDto)listBox1.SelectedItem).SafetyAlert) withOutPictureBox.Image = Resource1.downloaded1;
                    else withOutPictureBox.Image = Resource1.withoutPrescriptionOff;
                    vigilanePictureBox.Image = ViewHelper.getVigilanceIcon(product);
                    genericPictureBox.Image = ViewHelper.getGenericIcon(product);
                    indicListBox.Items.AddRange(helper.getProductIndicator((int)product.Id).ToArray());
                    searchPosologieDescription((int)product.Id);
                    listBoxCI.Items.AddRange(helper.searchCIAlert((int)product.Id, age, weight, BreastFeedingDto.NONE, 0, creatin, GenderDto.MALE).ToArray<string>());
                    listBoxPE.Items.AddRange(helper.searchPEAlert((int)product.Id, age, weight, BreastFeedingDto.NONE, 0, creatin, GenderDto.MALE).ToArray<string>());

                }
                else if (packRadioButton.Checked)
                {
                    linkLabel1.Tag = (PackDto)listBox1.SelectedItem;
                    linkLabel1.Text = ((PackDto)listBox1.SelectedItem).Name;
                    if (((PackDto)listBox1.SelectedItem).SafetyAlert) withOutPictureBox.Image = Resource1.downloaded1;
                    else withOutPictureBox.Image = Resource1.withoutPrescriptionOff;

                    //need product info
                    ProductDto product = helper.searchByProductId((int)((PackDto)listBox1.SelectedItem).ProductId);
                    vigilanePictureBox.Image = ViewHelper.getVigilanceIcon(product);
                    genericPictureBox.Image = ViewHelper.getGenericIcon(product);
                    indicListBox.Items.AddRange(helper.getProductIndicator((int)product.Id).ToArray());
                    searchPosologieDescription((int)((PackDto)listBox1.SelectedItem).ProductId);
                    listBoxCI.Items.AddRange(helper.searchCIAlert((int)((PackDto)listBox1.SelectedItem).ProductId, age, weight, breast, weeks, creatin, gender).ToArray<string>());
                    listBoxPE.Items.AddRange(helper.searchPEAlert((int)((PackDto)listBox1.SelectedItem).ProductId, age, weight, breast, weeks, creatin, gender).ToArray<string>());
                }
                else if (prescRadioButton.Checked)
                {
                    BrandedPrescribableDto presc = (BrandedPrescribableDto)listBox1.SelectedItem;
                    linkLabel1.Tag = presc;
                    linkLabel1.Text = presc.Name;
                    if (presc.SafetyAlert == true) withOutPictureBox.Image = Resource1.downloaded1;
                    vigilanePictureBox.Image = Resource1.vigilanceOff;
                    genericPictureBox.Image = Resource1.genericLargeOff;
                    searchPosologieDescription((int)(presc).Id);
                }

            }
            else
            {
                MessageBox.Show("select a Drug");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

      


        private void searchPosologieDescription(int productId)
        {
            unitComboBox.Visible = true;
            freqComboBox.Visible = true;
            numericUpDown1.Visible = true;

            List<int> indications = new List<int>();
            List<int> routes = new List<int>();


            float weight = -1;
            int height = -1;
            int creatin = -1;
            
            GenderDto? gender = null;
            HepaticInsufficiencyDto? hepatic = null;
            if (patientControl2.getPoidCheckBox() == false)
            {
                weight = patientControl2.getWeightBoxValue();
            }
            if (patientControl2.getTailleCheckBoxChecked() == false)
            {
                height = patientControl2.getHeightBoxValue();
            }
            if (patientControl2.getCreatinCheckBoxChecked() == false)
            {
                creatin = patientControl2.getCreatinBoxValue();
            }
            
            if (patientControl2.getGenderCheckBoxChecked() == false)
            {
                gender = patientControl2.getGenderBoxSelectedItem();
            }
            
            if (patientControl2.getHepatCheckBoxChecked() == false)
            {
                hepatic = patientControl2.getHepaticBoxSelectedItem();
            }
            DateTime age = patientControl2.getMonthCalendar1SelectionStart();
            float ageF = (DateTime.Now.Year - age.Year) + (((DateTime.Now.Month -  age.Month) * 10) * (1/12));
            
            //Récupération des descripteurs posologique sur lesquels se baser pour que la sécurisation fonctionne
            List<NumberOfDosesDto> result = helper.PosoService_searchDosesByProductId(
                productId,
                gender,
                ageF,
                weight,
                height,
                creatin,
                hepatic,
                indications, routes);
            //Ici on travaille en Dose : comprimé, géllule ... nous pouvons aussi travailler en dosage du Principe Actif, dans ce cas utiliser l'API :
            //vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchActivePrincipleDosesByProductId

            if (result != null && result.Count > 0)
            {
                //Liste unique pour l'instant car indications et routes non prises en compte => toutes les voies d'administration et toutes les indications confondues
                foreach (NumberOfDosesDto numOfDoses in result)
                {
                    //Alertes eventuelles
                    TreeNode alertes = new TreeNode();
                    alertes.Text = "alertes";
                    foreach (SimplePosologyAlertDto alert in numOfDoses.Alerts)
                    {
                        TreeNode alertLeaf = new TreeNode();
                        alertLeaf.Text = alert.PosologyAlert.Text;
                        alertes.Nodes.Add(alertLeaf);
                    }

                    //Posology Max Absolue
                    TreeNode maxAbs = new TreeNode();
                    maxAbs.Name = "Posologie Maximum Absolu";
                    maxAbs.Text = "Posologie Maximum Absolu";
                    TreeNode maxAbsLeaf = new TreeNode();
                    if (numOfDoses.MaxAbsoluteNumberOfDose != null)
                    {
                        maxAbsLeaf.Text = numOfDoses.MaxAbsoluteNumberOfDose.Value + " " + numOfDoses.MaxAbsoluteNumberOfDose.Unit.Name + " " + numOfDoses.MaxAbsoluteNumberOfDose.Type;
                    }
                    else
                    {
                        maxAbsLeaf.Text = " Pas de Posologie Maximale Absolue";
                    }
                    maxAbs.Nodes.Add(maxAbsLeaf);

                    //Posologies Usuelles : Max et Min
                    TreeNode usualDoses = new TreeNode();
                    usualDoses.Name = "Posologies Usuelles";
                    usualDoses.Text = "Posologies Usuelles";
                    if (numOfDoses.UsualNumberOfDoseRange != null)
                    {
                        TreeNode usualMinDose = new TreeNode();
                        usualMinDose.Name = "Posologie Usuelle Min";
                        usualMinDose.Text = "Posologie Usuelle Min";
                        TreeNode usualMaxDose = new TreeNode();
                        usualMaxDose.Name = "Posologie Usuelle Max";
                        usualMaxDose.Text = "Posologie Usuelle Max";

                        TreeNode usualMinDoseLeaf = new TreeNode();
                        usualMinDoseLeaf.Text = numOfDoses.UsualNumberOfDoseRange.Min.Value + " " + numOfDoses.UsualNumberOfDoseRange.Min.Unit.Name + " " + numOfDoses.UsualNumberOfDoseRange.Min.Type;
                        usualMinDose.Nodes.Add(usualMinDoseLeaf);
                        //Se baser sur ... pour initialiser le formulaire de saisie de la posologie afin de prescrire dans les bonnes unitées
                        initPosoForm(numOfDoses.UsualNumberOfDoseRange.Min.Unit, numOfDoses.UsualNumberOfDoseRange.Min.Type);

                        TreeNode usualMaxDoseLeaf = new TreeNode();
                        usualMaxDoseLeaf.Text = numOfDoses.UsualNumberOfDoseRange.Max.Value + " " + numOfDoses.UsualNumberOfDoseRange.Max.Unit.Name + " " + numOfDoses.UsualNumberOfDoseRange.Max.Type;
                        usualMaxDose.Nodes.Add(usualMaxDoseLeaf);

                        usualDoses.Nodes.Add(usualMaxDose);
                        usualDoses.Nodes.Add(usualMinDose);
                    }
                    else{
                        initUnitNoPoso(productId);
                    }

                    //Voies d'administrations
                    TreeNode routesNode = new TreeNode();
                    routesNode.Name = "Voies d'administrations";
                    routesNode.Text = "Voies d'administrations";
                   if(numOfDoses.Routes!=null){
                       foreach (RouteDto route in numOfDoses.Routes)
                       {
                           TreeNode routeLeaf = new TreeNode();
                           routeLeaf.Text = route.Name;
                           routeLeaf.Name = route.Name;
                           routesNode.Nodes.Add(routeLeaf);
                       }
                   }

                   //durées
                   TreeNode durationNode = new TreeNode();
                   durationNode.Name = "Durées";
                   durationNode.Text = "Durées";
                   if (numOfDoses.UsualDurationRange != null)
                   {
                       if (numOfDoses.UsualDurationRange.Min != null)
                       {
                           TreeNode minDurationLeaf = new TreeNode();
                           minDurationLeaf.Text = numOfDoses.UsualDurationRange.Min.Value.ToString() + " " + numOfDoses.UsualDurationRange.Min.Type;
                           minDurationLeaf.Name = numOfDoses.UsualDurationRange.Min.Value.ToString() + " " + numOfDoses.UsualDurationRange.Min.Type;
                           durationNode.Nodes.Add(minDurationLeaf);
                       }
                       if (numOfDoses.UsualDurationRange.Max != null)
                       {
                           TreeNode maxDurationLeaf = new TreeNode();
                           maxDurationLeaf.Text = numOfDoses.UsualDurationRange.Max.Value.ToString() + " " + numOfDoses.UsualDurationRange.Max.Type;
                           maxDurationLeaf.Name = numOfDoses.UsualDurationRange.Max.Value.ToString() + " " + numOfDoses.UsualDurationRange.Max.Type;
                           durationNode.Nodes.Add(maxDurationLeaf);
                       }
                   }


                    treeView1.Nodes.Add(alertes);
                    treeView1.Nodes.Add(maxAbs);
                    treeView1.Nodes.Add(usualDoses);
                    treeView1.Nodes.Add(routesNode);
                    treeView1.Nodes.Add(durationNode);
                }

            }
            else
            {
                initUnitNoPoso(productId);
            }

        }

        private void initUnitNoPoso(int drugId)
        {
            treeView1.Nodes.Add("Pas de Posologie Structurée Disponible");
            //Si il n'y a pas de posologies structurées => il ne peut y avoir de contrôle sur la posologie faits par VIDAL.
            //Toutefois vous pouvez proposer les chmaps suivant à vtre prescripteur:
            //la liste des unités de dispensation connues
            //VidalAPI.Domain.PosologyUnitList units = vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchPosologyUnitByProductId(productId);
            //unitComboBox.Items.AddRange(units.ToArray<VidalAPI.Domain.PosologyUnit>());
            //unitComboBox.SelectedIndex = 0;

            treeView1.Nodes.Add("Pas de Posologie Structurée Disponible");

            unitComboBox.Visible = true;
            freqComboBox.Visible = true;
            numericUpDown1.Visible = true;

            if(vmpButton2.Checked){    
                List<PosologyUnitDto> unitList = helper.PosoService_searchPosologyUnitByCommonNameGroupId(drugId);
                unitComboBox.Items.AddRange(unitList.ToArray<PosologyUnitDto>());
                unitComboBox.SelectedIndex = 0;
            }
            else if (prescRadioButton.Checked)
            {
                unitComboBox.Items.Clear();
            }
            else {
                List<PosologyUnitDto> unitList = helper.PosoService_searchPosologyUnitByProductId(drugId);
                unitComboBox.Items.AddRange(unitList.ToArray<PosologyUnitDto>());
                if(unitComboBox.Items.Count > 0){
                    unitComboBox.SelectedIndex = 0;
                }
            }           
        }


       


        

      
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count>0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                analysePrescription();
            }
            else
            {
                MessageBox.Show("select a prescription line");
            }
        }

        private void analysePrescription()
        {
            string patient = patientControl2.getPatientJson();
           if(patient!=null && patient!=""){
            
           
           
            ServiceAnalysis.ArrayOfString prescr = new ServiceAnalysis.ArrayOfString();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[GRID_NAME].Value!=null && row.Cells[GRID_NAME].ToolTipText != "")
                {
                     prescr.Add((string)row.Cells[GRID_NAME].ToolTipText);
                }
            }
                DateTime now = DateTime.Now;
                PrescriptionAnalysisDto result =  helper.AnalysisService_getAlerts(patient,prescr);
                if (result != null)
                {
                    DateTime fin = DateTime.Now;
                    listBox2.Items.Add(fin - now);

                    for (int i = 0; i < result.PrescriptionLineAnalysisList.Count; i++)
                    {
                        PrescriptionLineAnalysisDto line = result.PrescriptionLineAnalysisList[i];
                        if (line.Drug.safetyAlert == false)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                         if (line.AlertList != null)
                        {
                            var iam = from a in line.AlertList where a.Type == "DRUG_INTERACTION" select a;
                            SetAlert(GRID_IAM, i, iam);
                        
                            var CI = from a in line.AlertList where a.Type == "CONTRA_INDICATION" select a;
                            SetAlert(GRID_CI, i, CI);
                        
                            var PE = from a in line.AlertList where a.Type == "PRECAUTION" select a;
                            SetAlert(GRID_PE, i, PE);
                        
                            var sub = from a in line.AlertList where a.Type == "ALLERGY" select a;
                            SetAlert(GRID_SUB, i, sub);
                        
                            var poso = from a in line.AlertList where a.Type == "POSOLOGY" select a;
                            SetAlert(GRID_POSO, i, poso);
                        
                            var warnings = from a in line.AlertList where a.Type == "WARNING" select a;
                            SetAlert(GRID_MEG, i, warnings);
                        
                            var surve = from a in line.AlertList where a.Type == "SURVEILLANCE" select a;
                            SetAlert(GRID_SURVEILLANCE, i, surve);
                        
                            var pci = from a in line.AlertList where a.Type == "PHYSICO_CHEMICAL_INTERACTION" select a;
                            SetAlert(GRID_PCI, i, pci);
                        
                            var redondance = from a in line.AlertList where a.Type == "REDUNDANT_ACTIVE_INGREDIENT" select a;
                            SetAlert(GRID_REDUNDANT, i,redondance);
                        }

                        
                    }
                }
            }
        }


        private void SetAlert(int col, int line,IEnumerable<AlertDto> alerts)
        {
            if (alerts != null && alerts.Count() > 0)
            {
                string comment = getAllAlertComment(alerts);
                dataGridView1[col, line].Value = ViewHelper.getLevelImage(alerts);
                dataGridView1[col, line].ToolTipText = comment;
            }
            else
            {
                dataGridView1[col, line].Value = Resource1.downloaded1;
                string comment = "No alert";
                dataGridView1[col, line].ToolTipText = comment;
            }
        }


        private static string getAllAlertComment(IEnumerable<AlertDto> iam )
        {
            string comment = "";
            foreach (AlertDto alert in iam)
            {
                comment +="Title : "+ alert.Title + "\n";
                comment +="Comment : "+ alert.Comment + "\n";
                if (alert.relatedElements != null && alert.relatedElements.Count>0)
                {
                    comment += "Related : " + alert.relatedElements[0].Type + " : " + (alert.relatedElements[0].Id !=null ? alert.relatedElements[0].Id.ToString() : "")+ "\n" ;
                }
            }
            return comment;
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            flashTreeView.Nodes.Clear();

            string patient = patientControl2.getPatientJson();
            List<string> prescr = new List<string>();
            foreach( DataGridViewRow row in dataGridView1.Rows){
                if (row.Cells[GRID_NAME].Value != null)
                {
                    prescr.Add((string)row.Cells[GRID_NAME].ToolTipText);
                }
            }

            List<DrugSummarizedAlertCoupleDto> flash =  helper.AnalysisService_getSummarizedAlert(patient,prescr);
            TreeNode PrescrAlert = new TreeNode();
            if (flash != null)
            {
                foreach ( DrugSummarizedAlertCoupleDto couple in flash)
                {
                    TreeNode Alert = new TreeNode();
                    Alert.Text = couple.SummarizedDrug.Id.ToString();

                    TreeNode allergyAlert = new TreeNode();
                    allergyAlert.Text = "Allergie : " + couple.SummarizedAlert.AllergiesAlert;
                    Alert.Nodes.Add(allergyAlert);

                    TreeNode iamAlert = new TreeNode();
                    iamAlert.Text = "Alertes IAM : " + couple.SummarizedAlert.InteractionsAlert;
                    Alert.Nodes.Add(iamAlert);

                    TreeNode ciAlert = new TreeNode();
                    ciAlert.Text = "Alertes CI : " + couple.SummarizedAlert.ContraIndicationsAlert;
                    Alert.Nodes.Add(ciAlert);

                    TreeNode peAlert = new TreeNode();
                    peAlert.Text = "Alertes PE : " + couple.SummarizedAlert.PrecautionsAlert;
                    Alert.Nodes.Add(peAlert);

                    TreeNode redundantAlert = new TreeNode();
                    redundantAlert.Text = "Alertes redondances : " + couple.SummarizedAlert.RedundantInteractionsAlert;
                    Alert.Nodes.Add(redundantAlert);

                    TreeNode posoAlert = new TreeNode();
                    posoAlert.Text = "Alertes posos : " + couple.SummarizedAlert.PosologyAlert;
                    Alert.Nodes.Add(posoAlert);

                    TreeNode physicoAlert = new TreeNode();
                    physicoAlert.Text = "Alertes physicoChimique : " + couple.SummarizedAlert.PhysicoChemicalAlert;
                    Alert.Nodes.Add(physicoAlert);

                    PrescrAlert.Nodes.Add(Alert);
                }
            }
            flashTreeView.Nodes.Add(PrescrAlert);

           AnalyseForm analyse =  new AnalyseForm(helper.AnalysisService_getAlertsAsHTML(patient,prescr));
           analyse.Show();
         /*  ServiceAnalysis.prescriptionCostAnalysis prices = AnalysisService_getPrescriptionCostAnalysis(prescr);
           for(int i=0;i< prices.prescriptionLineCostList.Count;i++){
               if(prices.prescriptionLineCostList[i].priceRange != null){
               dataGridView1[GRID_COST,i].Value = prices.prescriptionLineCostList[i].priceRange.minPrice;
               }
               else{
               dataGridView1[GRID_COST,i].Value = "NC";
               }

           }*/
            //MessageBox.Show("Prix estimatif : " + prices.MinPrice);

        }

    //    private ServiceAnalysis.prescriptionCostAnalysis AnalysisService_getPrescriptionCostAnalysis(ServiceAnalysis.ArrayOfString prescr)
      //  {
           // throw new NotImplementedException();
       // }


               

        private void smrButton_Click(object sender, EventArgs e)
        {
            if (productButton.Checked)
            {
                SmrForm smr = new SmrForm(helper.SmrService_getSmrAsmrAsHTML((int)((ProductDto)listBox1.SelectedItem).Id));
                smr.Show();

            }
            else if (packRadioButton.Checked)
            {
                SmrForm smr = new SmrForm(helper.SmrService_getSmrAsmrAsHTML((int)((PackDto)listBox1.SelectedItem).ProductId));
                smr.Show();
            }
            else if (ucdRadioButton.Checked)
            {
                ProductDto product = helper.ProductService_searchByUcdId((int)((UcdDto)listBox1.SelectedItem).Id);
                SmrForm smr = new SmrForm(helper.SmrService_getSmrAsmrAsHTML((int)product.Id));
                smr.Show();

                     }
            
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            List<string> prescr = new List<string>();
            StreamWriter monStreamWriter = new StreamWriter("extract_"+DateTime.Now.Millisecond+".txt");
            monStreamWriter.AutoFlush = true;
            monStreamWriter.WriteLine( patientControl2.getPatientJson());
            foreach (DataGridViewRow row in dataGridView1.Rows)
            
            {
                if (row.Cells[GRID_NAME].Value != null)
                {
                    monStreamWriter.WriteLine((string)row.Cells[GRID_NAME].ToolTipText);
                   
                    
                }
            }
            MessageBox.Show("extarction terminée");
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (linkLabel1.Tag is ProductDto)
            {
                List<String> urls = helper.getDocumentsByProductId( ((ProductDto)linkLabel1.Tag).Id);
                foreach (string url in urls)
                {
                    Process.Start(url);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (linkLabel1.Tag is UcdDto)
            {
                new CircuitMedic( helper,((UcdDto)linkLabel1.Tag).Id ).Show();
            }
            
        }

        private void recosbutton_Click(object sender, EventArgs e)
        {

            if(patientControl2.getPatientJson()!=null || (dataGridView1!=null && dataGridView1.Rows !=null) )
            {
                 string patient = patientControl2.getPatientJson();
                List<string> prescr = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[GRID_NAME].Value != null)
                    {
                        prescr.Add((string)row.Cells[GRID_NAME].ToolTipText);
                    }
                }
                 RecosForm analyse =  new RecosForm(prescr,patient,helper);
                 analyse.Show();
            }
        }


    }
}
