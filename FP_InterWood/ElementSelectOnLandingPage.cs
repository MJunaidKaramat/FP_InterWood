using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace FP_InterWood
{
    public class ElementSelectOnLandingPage : GeneralMethodsClass
    {
        #region selectItemElements
        By officeChair = By.XPath("//*[@id=\"root\"]/main/div[4]/div[2]/div[2]/div/div/div/div/section/div/div/div[4]");
        By scrollToPoint = By.XPath("//*[@id=\"root\"]/main/div[4]/article/section[2]/div/div/div[20]/div/div/div/div[2]/h3/a");
        By loadMoreButton = By.XPath("//button[@class='btn-load-more']");//*[@id="root"]/main/div[4]/article/button
        By visitorChairItem = By.XPath("//*[@id=\"root\"]/main/div[4]/article/section[2]/div/div/div[25]/div/div/figure/a/div/img[2]");
        By incrementItemCount = By.XPath("//*[@id=\"root\"]/main/div[4]/div[2]/form/section[1]/div[1]/button[2]");
        By countBox = By.XPath("//input[@name='quantity']");
        By decrementItemCount = By.XPath("//*[@id=\"root\"]/main/div[4]/div[2]/form/section[1]/div[1]/button[1]");
        By addToCartButton = By.XPath("//*[@id=\"root\"]/main/div[4]/div[2]/form/section[2]/button");
        By readMoreButton = By.XPath("//*[@id=\"desc\"]/div/button");
        By installmentBankDetail = By.XPath("//*[@id=\"root\"]/main/div[4]/div[2]/div[2]/div[2]/button/a");
        By installmentBank = By.Id("installmentMonths");
        #endregion

        public void selectObject()
        {
            scrollToElementClick(officeChair);
            scrollToElement(scrollToPoint);
            ClickableItem(loadMoreButton);
            scrollToElementClick(visitorChairItem);
            ClickableItem(incrementItemCount);
            ClickableItem(incrementItemCount);
            ClickableItem(incrementItemCount);
            decrementItemTo1();
            readMoreOption();
            intallmentBankDetailsFunc();
            switchFrame();
            selectBank();
            //addToCart();
        }
        public void decrementItemTo1()
        {
            IWebElement decrementButton = returnElement(decrementItemCount);

            while (decrementButton.Enabled)
            {
                ClickableItem(decrementItemCount);
            }
            //string v = findElement(countBox).GetAttribute("value");
            //while(Convert.ToInt32(v)!=1)
            //{
            //    ClickableItem(decrementItemCount);
            //}
        }
        public void addToCart()
        {
            ClickableItem(addToCartButton);
        }
        public void readMoreOption()
        {
            scrollToElementClick(readMoreButton);
        }
        public void intallmentBankDetailsFunc()
        {
            ClickableItem(installmentBankDetail);
        }
        public void switchFrame()
        {
            switchToChildFrame();
        }
        public void selectBank()
        {
            dropDownItemSelect(installmentBank, "3");
        }

    }
}
