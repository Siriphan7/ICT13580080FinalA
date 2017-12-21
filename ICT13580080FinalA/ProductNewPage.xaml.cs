using System;
using System.Collections.Generic;
using ICT13580080FinalA.model;
using Xamarin.Forms;

namespace ICT13580080FinalA
{
    public partial class ProductNewPage : ContentPage
    {
        public ProductNewPage()
        {
            InitializeComponent();
            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
            sexPicker.Items.Add("ชาย");
			sexPicker.Items.Add("หญิง");
            departPicker.Items.Add("ฝ่ายช่างภาพ");
			departPicker.Items.Add("ฝ่ายกราฟิกดีไซน์");
			departPicker.Items.Add("ฝ่ายตัดต่อ");
            statusPicker.Items.Add("โสด");
            statusPicker.Items.Add("แต่งงาน");
            statusPicker.Items.Add("หย่าร้าง");

        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOK = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่ ", "ไม่ใช่");

            if(isOK)
            {
                var product = new Product();
				product.Name = nameEntry.Text;
                product.Surename = surenameEntry.Text;
                product.Yearold = int.Parse(yearoldEntry.Text);
                product.Sex = sexPicker.SelectedItem.ToString();

                product.Department = departPicker.SelectedItem.ToString();
                product.Telephone = int.Parse(phoneEntry.Text);
				product.Email = emailEntry.Text;
				product.Address = addressEditor.Text;
				product.Status = statusPicker.SelectedItem.ToString();
                product.Chlidrens =  int.Parse(valuesonslider.Text);
                product.Salary = int.Parse(valuemoneyslid.Text);


				var id = App.DbHelper.AddProduct(product); 
				await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ#" + id, "ตกลง");


            }
        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}


