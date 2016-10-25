using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ExemplePoso
{
    public partial class Form1 : Form
    {
       static VidalAPI.ProductLine vidalProduct ;
        public Form1()
        {
            WorkerId workerObjet = new WorkerId();
            Thread worker = new Thread(workerObjet.DoWork);
            worker.Start();

            InitializeComponent();

            //Initialisation de la boîte du choix du sexe
            
            genderBox.Items.Add(VidalAPI.Domain.Gender.GENDER_FEMALE);
            genderBox.Items.Add(VidalAPI.Domain.Gender.GENDER_MALE);
            
            genderBox.SelectedIndex = 0;

            //Initialisation des insuffisances hépatique :
            
            hepaticBox.Items.Add(VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_NONE);
            hepaticBox.Items.Add(VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_MODERATE);
            hepaticBox.Items.Add(VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_SEVERE);
            hepaticBox.Items.Add(VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_JNULL);
            
            hepaticBox.SelectedIndex = 0;

            //Initialisation du contexte d'allaitement
            breathFeedingBox.Items.Add(VidalAPI.Domain.Breastfeeding.BREASTFEEDING_NONE);
            breathFeedingBox.Items.Add(VidalAPI.Domain.Breastfeeding.BREASTFEEDING_ALL);
            breathFeedingBox.Items.Add(VidalAPI.Domain.Breastfeeding.BREASTFEEDING_LESS_THAN_ONE_MONTH);
            breathFeedingBox.Items.Add(VidalAPI.Domain.Breastfeeding.BREASTFEEDING_MORE_THAN_ONE_MONTH);
            breathFeedingBox.Items.Add(VidalAPI.Domain.Breastfeeding.BREASTFEEDING_JNULL);
            breathFeedingBox.SelectedIndex = 0;

            //Initialisation de la boîte de sélection des fréquence posologiques
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_2_DAYS);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_24_HOURS);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_DAY);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_HOUR);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_MINUTE);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_MONTH);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_N_HOURS);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_WEEK);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_YEAR);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_THIS_DAY);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_TYPE_44);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_TYPE_46);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_TYPE_66);
            freqComboBox.Items.Add(VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_JNULL);
            
            freqComboBox.SelectedIndex = 2;

            //Initialisation de la boîte de sélection des durées
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_DAY);
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_HOUR);
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_MINUTE);
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_MONTH);
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_WEEK);
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_YEAR);
            dureeComboBox.Items.Add(VidalAPI.Domain.DurationType.DURATIONTYPE_JNULL);

            dureeComboBox.SelectedIndex = 0;

            //Initialisation de la boîte de ActiveDose
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_G);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_MG);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_MCG);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_KU);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_U);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_MU);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_ML);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_MMOL);
            activeDosecomboBox.Items.Add(VidalAPI.Domain.DoseUnit.DOSEUNIT_JNULL);

            activeDosecomboBox.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (productButton.Checked)
            {
                VidalAPI.Domain.ProductList result = vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchByName(textBox1.Text);
                foreach (VidalAPI.Domain.Product product in result)
                {
                    listBox1.Items.Add(product);
                }
            }
            else if (vmpButton2.Checked)
            {
                VidalAPI.Domain.CommonNameGroupList result = vidalProduct.GetService<VidalAPI.Services.CommonNameGroupService>().SearchByName(textBox1.Text);
                foreach (VidalAPI.Domain.CommonNameGroup cng in result)
                {
                    listBox1.Items.Add(cng);
                }
            }
            else if (packRadioButton.Checked)
            {
                VidalAPI.Domain.PackList result = vidalProduct.GetService<VidalAPI.Services.PackService>().SearchByName(textBox1.Text);
                foreach (VidalAPI.Domain.Pack pack in result)
                {
                    listBox1.Items.Add(pack);
                }
            }
            else if (ucdRadioButton.Checked)
            {
                VidalAPI.Domain.UcdList result = vidalProduct.GetService<VidalAPI.Services.UcdService>().SearchByName(textBox1.Text);
                foreach (VidalAPI.Domain.Ucd ucd in result)
                {
                    listBox1.Items.Add(ucd);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
   
        }

        private string patientToJson()
        {
            List<int> allergies = new List<int>();
            foreach(VidalAPI.Domain.Allergy allergy in allergyPatientListBox.Items)
            {
                allergies.Add(allergy.Id);
            }

            List<int> molecules = new List<int>();
            foreach(VidalAPI.Domain.Molecule molecule in moleculePatientListBox.Items){
                molecules.Add(molecule.Id);
            }
            
            List<int> cims = new List<int>();
            foreach(VidalAPI.Domain.Cim10 cim in cimPatientlistBox.Items)
            {
                cims.Add(cim.Id);
            }

            int weight = -1;
            int height = -1;
            int creatin = -1;
            int amen = -1;
            VidalAPI.Domain.Gender gender = VidalAPI.Domain.Gender.GENDER_JNULL;
            VidalAPI.Domain.Breastfeeding breathFeeding = VidalAPI.Domain.Breastfeeding.BREASTFEEDING_JNULL;
            VidalAPI.Domain.HepaticInsufficiency hepatic = VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_JNULL;
            if (poidCheckBox.Checked == false)
            {
                weight = (int)weightBox.Value;
            }
            if (TailleCheckBox.Checked == false)
            {
                height = (int)heightBox.Value;
            }
            if (creatinCheckBox.Checked == false)
            {
                creatin = (int)creatinBox.Value;
            }
            if (amenCheckBox.Checked == false)
            {
                amen = (int)amenBox.Value;
            }
            if (genderCheckBox.Checked == false)
            {
                gender = (VidalAPI.Domain.Gender)genderBox.SelectedItem;
            }
            if (allaitCheckBox.Checked == false)
            {
                breathFeeding = (VidalAPI.Domain.Breastfeeding)breathFeedingBox.SelectedItem;
            }
            if (hepatCheckBox.Checked == false)
            {
                hepatic = (VidalAPI.Domain.HepaticInsufficiency)hepaticBox.SelectedItem;
            }
            
           return vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().PatientFromObjToJson(
                monthCalendar1.SelectionStart,
                gender,
                weight,
                height,
                amen,
                breathFeeding,
                creatin,
                hepatic,
                allergies,
                molecules,
                cims);
            //return "{\"allergyIds\":null,\"breastFeeding\":null,\"creatin\":null,\"dateOfBirth\":63068400000,\"gender\":\"MALE\",\"height\":null,\"hepaticInsufficiency\":null,\"moleculeIds\":[],\"pathologyCim10Ids\":[],\"weeksOfAmenorrhea\":null,\"weight\":null}";


        }

        private void initPosoForm(VidalAPI.Domain.PosologyUnit unit, VidalAPI.Domain.PosologyFrequencyType type)
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
            VidalAPI.Domain.DrugType type = VidalAPI.Domain.DrugType.DRUGTYPE_UNKNOWN;
            int id=0;
            if (productButton.Checked)
            {
                type = VidalAPI.Domain.DrugType.DRUGTYPE_PRODUCT;
                id = ((VidalAPI.Domain.Product)listBox1.SelectedItem).Id;
                name = ((VidalAPI.Domain.Product)listBox1.SelectedItem).Name;
            }
            else if (vmpButton2.Checked)
            {
                type = VidalAPI.Domain.DrugType.DRUGTYPE_COMMON_NAME_GROUP;
                id = ((VidalAPI.Domain.CommonNameGroup)listBox1.SelectedItem).Id;
                name = ((VidalAPI.Domain.CommonNameGroup)listBox1.SelectedItem).Name;
            }
            else if (packRadioButton.Checked)
            {
                type = VidalAPI.Domain.DrugType.DRUGTYPE_PACK;
                id = ((VidalAPI.Domain.Pack)listBox1.SelectedItem).Id;
                name = ((VidalAPI.Domain.Pack)listBox1.SelectedItem).Name;
            }
            else if (ucdRadioButton.Checked)
            {
                type = VidalAPI.Domain.DrugType.DRUGTYPE_UCD;
                id = ((VidalAPI.Domain.Ucd)listBox1.SelectedItem).Id;
                name = ((VidalAPI.Domain.Ucd)listBox1.SelectedItem).Name;
            }


            VidalAPI.Domain.PosologyFrequencyType freq = VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_DAY;

            if(numericUpDown1.Visible)
            {
                dose = (double)numericUpDown1.Value;
            }
            if (unitComboBox.Visible && enDoseButton.Checked)
            {
                unit = ((VidalAPI.Domain.PosologyUnit)unitComboBox.SelectedItem).Id;
            }
            if (freqComboBox.Visible)
            {
                freq = (VidalAPI.Domain.PosologyFrequencyType)freqComboBox.SelectedItem;
            }

         
            //VidalAPI.Domain.PosologyAlerts result = vidalProduct.GetService<VidalAPI.Services.PosologyService>().CheckDailyDoseByProductId(((VidalAPI.Domain.Product)listBox1.SelectedItem).Id, dose, ((VidalAPI.Domain.PosologyUnit)unitComboBox.SelectedItem).Id, (VidalAPI.Domain.PosologyFrequencyType)freqComboBox.SelectedItem, (VidalAPI.Domain.Gender)genderBox.SelectedItem, 40f, (float)weightBox.Value, (int)heightBox.Value, (int)creatinBox.Value, (VidalAPI.Domain.HepaticInsufficiency)hepaticBox.SelectedItem, indications, routes);
           string prescrLine =  "";
           if (enDoseButton.Checked)
           {
               prescrLine = vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().PrescriptionLineInDosesFromObjToJson(
                   dose,
                   unit,
                   freq,
                   indications,
                   routes,
                   id,
                   type,
                   (int)dureeNumericUpDown.Value,
                   (VidalAPI.Domain.DurationType)dureeComboBox.SelectedItem
                   );
           }
           else if(enPaButton.Checked){
               prescrLine = vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().PrescriptionLineInActivePrincipleDosesFromObjToJson(
                   dose,
                   (VidalAPI.Domain.DoseUnit)activeDosecomboBox.SelectedItem,
                   freq,
                   indications,
                   routes,
                   id,
                   type,
                   (int)dureeNumericUpDown.Value,
                   (VidalAPI.Domain.DurationType)dureeComboBox.SelectedItem
                   );
           }

           //string prescrLine2 = "{\"dose\":null,\"drug\":null,\"drugId\":15070,\"drugType\":\"PRODUCT\",\"frequencyType\":null,\"indicationIds\":null,\"posologyUnit\":null,\"routeIds\":[],\"unitId\":null}";

           dataGridView1.Rows.Add("",name,prescrLine);

        }

        private void resetForm()
        {
            treeView1.Nodes.Clear();
            unitComboBox.Items.Clear();
            freqComboBox.SelectedIndex = 0;
           
        }

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetForm();
            if (listBox1.SelectedItem != null)
            {

                if (productButton.Checked)
                {
                    linkLabel1.Text = ((VidalAPI.Domain.Product)listBox1.SelectedItem).Name + " (liste :" + ((VidalAPI.Domain.Product)listBox1.SelectedItem).ListValue + ") (Remb: " + ((VidalAPI.Domain.Product)listBox1.SelectedItem).RefundingRateValue + ")";
                    searchPosologieDescription(((VidalAPI.Domain.Product)listBox1.SelectedItem).Id);
                }
                else if (vmpButton2.Checked)
                {
                    linkLabel1.Text = ((VidalAPI.Domain.CommonNameGroup)listBox1.SelectedItem).Name;
                    initUnitNoPoso(((VidalAPI.Domain.CommonNameGroup)listBox1.SelectedItem).Id);
                }
                else if (ucdRadioButton.Checked)
                {
                    linkLabel1.Text = ((VidalAPI.Domain.Ucd)listBox1.SelectedItem).Name;
                    VidalAPI.Domain.Product product = vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchByUcdId(((VidalAPI.Domain.Ucd)listBox1.SelectedItem).Id);
                    searchPosologieDescription(product.Id);
                }
                else if (packRadioButton.Checked)
                {
                    linkLabel1.Text = ((VidalAPI.Domain.Pack)listBox1.SelectedItem).Name;
                    searchPosologieDescription(((VidalAPI.Domain.Pack)listBox1.SelectedItem).ProductId);
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

        private void button4_Click(object sender, EventArgs e)
        {
            patientJson.Items.Clear();
            patientJson.Items.Add(patientToJson());
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
            
            VidalAPI.Domain.Gender gender = (VidalAPI.Domain.Gender)(-1);
            VidalAPI.Domain.HepaticInsufficiency hepatic = (VidalAPI.Domain.HepaticInsufficiency)(-1);
            if (poidCheckBox.Checked == false)
            {
                weight = (int)weightBox.Value;
            }
            if (TailleCheckBox.Checked == false)
            {
                height = (int)heightBox.Value;
            }
            if (creatinCheckBox.Checked == false)
            {
                creatin = (int)creatinBox.Value;
            }
            
            if (genderCheckBox.Checked == false)
            {
                gender = (VidalAPI.Domain.Gender)genderBox.SelectedItem;
            }
            
            if (hepatCheckBox.Checked == false)
            {
                hepatic = (VidalAPI.Domain.HepaticInsufficiency)hepaticBox.SelectedItem;
            }
            DateTime age = monthCalendar1.SelectionStart;
            float ageF = (DateTime.Now.Year - age.Year) + (((DateTime.Now.Month -  age.Month) * 10) * (1/12));
            
            //Récupération des descripteurs posologique sur lesquels se baser pour que la sécurisation fonctionne
            VidalAPI.Domain.NumberOfDosesList result = vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchDosesByProductId(
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
                foreach (VidalAPI.Domain.NumberOfDoses numOfDoses in result)
                {
                    //Alertes eventuelles
                    TreeNode alertes = new TreeNode();
                    alertes.Text = "alertes";
                    foreach (VidalAPI.Domain.SimplePosologyAlert alert in numOfDoses.Alerts)
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
                       foreach (VidalAPI.Domain.Route route in numOfDoses.Routes)
                       {
                           TreeNode routeLeaf = new TreeNode();
                           routeLeaf.Text = route.Name;
                           routeLeaf.Name = route.Name;
                           routesNode.Nodes.Add(routeLeaf);
                       }
                   }

                    treeView1.Nodes.Add(alertes);
                    treeView1.Nodes.Add(maxAbs);
                    treeView1.Nodes.Add(usualDoses);
                    treeView1.Nodes.Add(routesNode);
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
                
            VidalAPI.Domain.CommonNameGroupPosologyUnitList unitList = vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchPosologyUnitByCommonNameGroupId(drugId);
            unitComboBox.Items.AddRange(unitList.PosologyUnits.ToArray<VidalAPI.Domain.PosologyUnit>());
            }
            else {
                VidalAPI.Domain.PosologyUnitList unitList = vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchPosologyUnitByProductId(drugId);
                unitComboBox.Items.AddRange(unitList.ToArray<VidalAPI.Domain.PosologyUnit>());
            }
            
            
            unitComboBox.SelectedIndex = 0;
        }


       


        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(genderCheckBox.Checked == true){
                genderBox.Visible = false;
            }
            else{
                 genderBox.Visible = true;
            }
        }

        private void allaitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allaitCheckBox.Checked == true)
            {
                breathFeedingBox.Visible = false;
            }
            else
            {
                breathFeedingBox.Visible = true;

            }
        }

        private void poidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (poidCheckBox.Checked)
            {
                weightBox.Visible = false;
            }
            else
            {
                weightBox.Visible = true;

            }
        }

        private void TailleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TailleCheckBox.Checked)
            {
                heightBox.Visible = false;
            }
            else
            {
                heightBox.Visible = true;
            }
        }

        private void amenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (amenCheckBox.Checked)
            {
                amenBox.Visible = false;
            }
            else
            {
                amenBox.Visible = true;
            }
        }

        private void creatinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (creatinCheckBox.Checked)
            {
                creatinBox.Visible = false;
            }
            else
            {
                creatinBox.Visible = true;
            }
        }

        private void hepatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hepatCheckBox.Checked)
            {
                hepaticBox.Visible = false;
            }
            else
            {
                hepaticBox.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected));
            }
            else
            {
                MessageBox.Show("select a prescription line");
            }
        }

        private void patientLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(patientJson.Items[0].ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flashTreeView.Nodes.Clear();

            string patient = patientJson.Items[0].ToString();
            List<string> prescr = new List<string>();
            foreach( DataGridViewRow row in dataGridView1.Rows){
                if (row.Cells[2].Value != null)
                {
                    prescr.Add((string)row.Cells[2].Value);
                }
            }

            VidalAPI.Domain.DrugSummarizedAlertCoupleList flash =  vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().GetSummarizedAlert(patient,prescr);
            TreeNode PrescrAlert = new TreeNode();
            if (flash != null)
            {
                foreach (VidalAPI.Domain.DrugSummarizedAlertCouple couple in flash)
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

           AnalyseForm analyse =  new AnalyseForm(vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().GetAlertsAsHTML(patient,prescr));
           analyse.Show();
           VidalAPI.Domain.PrescriptionCostAnalysis prices = vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().GetPrescriptionCostAnalysis(prescr);
           for(int i=0;i< prices.PrescriptionLineCostList.Count;i++){
               if(prices.PrescriptionLineCostList[i].PriceRange != null){
               dataGridView1[0,i].Value = prices.PrescriptionLineCostList[i].PriceRange.MinPrice;
               }
               else{
               dataGridView1[0,i].Value = "NC";
               }

           }
            //MessageBox.Show("Prix estimatif : " + prices.MinPrice);

        }


        //ALLERGY PANEL
        private void allergieButton_Click(object sender, EventArgs e)
        {
            allergyResultlistBox.Items.Clear();
            VidalAPI.Domain.AllergyList result =  vidalProduct.GetService<VidalAPI.Services.AllergyService>().SearchByName(allergieTextBox.Text);
            allergyResultlistBox.Items.AddRange(result.ToArray<VidalAPI.Domain.Allergy>());
        }

        private void allergyAdd_Click(object sender, EventArgs e)
        {
            if(allergyResultlistBox.SelectedItem!=null){
                allergyPatientListBox.Items.Add(allergyResultlistBox.SelectedItem);
            }
        }

        private void allergyRemove_Click(object sender, EventArgs e)
        {
            if (allergyPatientListBox.SelectedItem != null)
            {
                allergyPatientListBox.Items.Remove(allergyPatientListBox.SelectedItem);
            }
        }

        //MOLECULES PANEL
        private void moleculeButton_Click(object sender, EventArgs e)
        {
            moleculeSearchListBox.Items.Clear();
            VidalAPI.Domain.MoleculeList result = vidalProduct.GetService<VidalAPI.Services.MoleculeService>().SearchOnlySecuredMoleculeByName(moleculeTextBox.Text);
            moleculeSearchListBox.Items.AddRange(result.ToArray<VidalAPI.Domain.Molecule>());
        }

        private void moleculeAddButton_Click(object sender, EventArgs e)
        {
            if (moleculeSearchListBox.SelectedItem != null)
            {
                moleculePatientListBox.Items.Add(moleculeSearchListBox.SelectedItem);
            }
        }

        private void moleculeRemoveButton_Click(object sender, EventArgs e)
        {
            if (moleculePatientListBox.SelectedItem != null)
            {
                moleculePatientListBox.Items.Remove(moleculePatientListBox.SelectedItem);
            }
        }


        //Cim10 Panel
        private void cimSearchButton_Click(object sender, EventArgs e)
        {
            cimListBox.Items.Clear();
           VidalAPI.Domain.Cim10List result =  vidalProduct.GetService<VidalAPI.Services.Cim10Service>().SearchByName(cimTextBox.Text);
           cimListBox.Items.AddRange(result.ToArray<VidalAPI.Domain.Cim10>());
        }

        private void cimAddbutton_Click(object sender, EventArgs e)
        {
            if (cimListBox.SelectedItem != null)
            {
                cimPatientlistBox.Items.Add(cimListBox.SelectedItem);
            }
        }

        private void cimRemovebutton_Click(object sender, EventArgs e)
        {
            if(cimPatientlistBox.SelectedItem!=null){
                cimPatientlistBox.Items.Remove(cimPatientlistBox.SelectedItem);
            }
        }

        public class WorkerId
        {
            public WorkerId()
            {
            }

            public void DoWork()
            {

                Console.WriteLine("worker thread: working...");
                vidalProduct = VidalAPI.ProductLine.GetProduct(VidalAPI.ProductLineID.VIDALEXPERT_PRODUCTID);
                MessageBox.Show("Initialisation Terminée :) ");
            }

            public void RequestStop()
            {
                //_shouldStop = true;
            }
            // Volatile is used as hint to the compiler that this data
            // member will be accessed by multiple threads.
            //private volatile bool _shouldStop;
        }

        private void smrButton_Click(object sender, EventArgs e)
        {
            if (productButton.Checked)
            {
                SmrForm smr = new SmrForm(vidalProduct.GetService<VidalAPI.Services.SmrService>().GetSmrAsmrAsHTML(((VidalAPI.Domain.Product)listBox1.SelectedItem).Id));
                smr.Show();

            }
            else if (packRadioButton.Checked)
            {
                SmrForm smr = new SmrForm(vidalProduct.GetService<VidalAPI.Services.SmrService>().GetSmrAsmrAsHTML(((VidalAPI.Domain.Pack)listBox1.SelectedItem).ProductId));
                smr.Show();
            }
            else if (ucdRadioButton.Checked)
            {
                VidalAPI.Domain.Product product = vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchByUcdId(((VidalAPI.Domain.Ucd)listBox1.SelectedItem).Id);
                SmrForm smr = new SmrForm(vidalProduct.GetService<VidalAPI.Services.SmrService>().GetSmrAsmrAsHTML(product.Id));
                smr.Show();

                     }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
