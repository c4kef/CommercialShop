using System;

namespace Client.Manager
{
    [Serializable]
    class InterfaceTranslation
    {
        public string m_versionPack;

        public string m_successful;
        public string m_unsuccessful;

        public string m_incorrectKey;
        public string m_incorrectAnswer;
        public string m_windowNotFound;
        public string m_copiedMail;
        public string m_copiedMailCode;
        public string m_errorMessage;
        public string m_infoLoading;
        public string m_adminConfigNotFound;
        public string m_adminConfigIncorrect;
        public string m_adminSaveAccount;

        public string m_goodMorning;
        public string m_goodDay;
        public string m_goodEvening;
        public string m_goodNight;

        public string m_btnTooltipHide;

        //Main form
        public string m_mainBtnTooltipConnection;
        public string m_mainBtnTooltipInfo;
        public string m_mainBtnTooltipActivation;
        public string m_mainBalloonTipText;
        public string m_mainBalloonTipTitle;
        public string m_mainTooltipText;
        public string m_mainFormText;

        //Activation form
        public string m_activationBtnSendKeyText;
        public string m_activationInputKeyPlaceholderText;
        public string m_activationBtnCopyCodeFromMailText;
        public string m_activationBtnCopyMailText;

        //Awake form
        public string m_awakeLabelWait;

        //Info form
        public string m_infoLabelInfo;
        public string m_infoLabelContacts;

        //Admin form
        public string m_adminFormText;

        //Admin account form
        public string m_adminAccountPasswordPlaceholderText;
        public string m_adminAccountLoginPlaceholderText;
        public string m_adminAccountCountPlaceholderText;

        //Admin mail form
        public string m_adminMailPasswordPlaceholderText;
        public string m_adminMailLoginPlaceholderText;
        public string m_adminMailServerPlaceholderText;

        //Admin data send form
        public string m_adminDataSendLabelDataLoad;

        //Admin choose store form
        public string m_adminChooseStoreDropdownText;

        //Loading text form
        public string m_loadingTextForm;
    }
}
