﻿using System.Drawing;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using FontStyle = System.Drawing.FontStyle;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace DFAssist
{
    public class MainControl : UserControl
    {
        private TableLayoutPanel _mainTableLayout;
        private TableLayoutPanel _settingsTableLayout;
        private TabControl _appTabControl;
        private TabPage _mainTabPage;
        private TabPage _settingsPage;
        private Panel _settingsPanel;

        public LinkLabel CopyrightLink;
        public LinkLabel DonateLink;

        public GroupBox TestSettings;
        public GroupBox ToastSettings;
        public GroupBox TtsSettings;
        public GroupBox TelegramSettings;
        public GroupBox DiscordSettings;
        public GroupBox PushBulletSettings;
        public GroupBox GeneralSettings;

        public Button ClearLogButton;
        public Button TestConfigurationButton;

        public Label LanguageLabel;
        public Label AppTitle;
        public Label TelegramChatIdLabel;
        public Label TelegramTokenLabel;
        public Label DiscordWebhookLabel;
        public Label DiscordUsernameLabel;
        public Label PushBulletDeviceIdlabel;
        public Label PushBulletTokenLabel;
        public Label TtsVoiceSelectionLabel;
        public Label LogLevelSelectionLabel;

        public TextBox LanguageValue;
        public TextBox TelegramChatIdTextBox;
        public TextBox TelegramTokenTextBox;
        public TextBox DiscordWebhookTextBox;
        public TextBox DiscordUsernameTextBox;
        public TextBox PushBulletDeviceIdTextBox;
        public TextBox PushBulletTokenTextBox;

        public CheckBox TtsCheckBox;
        public CheckBox PersistToasts;
        public CheckBox DisableToasts;
        public CheckBox EnableActToast;
        public CheckBox EnableTestEnvironment;
        public CheckBox TelegramCheckBox;
        public CheckBox DiscordCheckBox;
        public CheckBox PushBulletCheckbox;
        public CheckBox FlashTaskbar;

        public ComboBox LanguageComboBox;
        public ComboBox TtsVoicesComboBox;
        public ComboBox LogLevelComboBox;

        public RichTextBox LoggingRichTextBox;

        public IActPluginV1 Plugin;

        public MainControl(IActPluginV1 plugin)
        {
            Plugin = plugin;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            LanguageLabel = new Label();
            LanguageValue = new TextBox();
            LanguageComboBox = new ComboBox();
            TtsVoicesComboBox = new ComboBox();
            LogLevelSelectionLabel = new Label();
            LogLevelComboBox = new ComboBox();
            EnableTestEnvironment = new CheckBox();
            TtsVoiceSelectionLabel = new Label();
            TtsCheckBox = new CheckBox();
            PersistToasts = new CheckBox();
            FlashTaskbar = new CheckBox();
            EnableActToast = new CheckBox();
            DisableToasts = new CheckBox();
            _appTabControl = new TabControl();
            _mainTabPage = new TabPage();
            _mainTableLayout = new TableLayoutPanel();
            ClearLogButton = new Button();
            TestConfigurationButton = new Button();
            LoggingRichTextBox = new RichTextBox();
            AppTitle = new Label();
            CopyrightLink = new LinkLabel();
            DonateLink = new LinkLabel();
            _settingsPage = new TabPage();
            _settingsPanel = new Panel();
            _settingsTableLayout = new TableLayoutPanel();
            TtsSettings = new GroupBox();
            TelegramSettings = new GroupBox();
            DiscordSettings = new GroupBox();
            TelegramChatIdLabel = new Label();
            TelegramChatIdTextBox = new TextBox();
            TelegramCheckBox = new CheckBox();
            DiscordCheckBox = new CheckBox();
            DiscordWebhookTextBox = new TextBox();
            DiscordUsernameTextBox = new TextBox();
            TelegramTokenLabel = new Label();
            TelegramTokenTextBox = new TextBox();
            DiscordWebhookLabel = new Label();
            DiscordUsernameLabel = new Label();
            PushBulletSettings = new GroupBox();
            PushBulletCheckbox = new CheckBox();
            PushBulletDeviceIdTextBox = new TextBox();
            PushBulletDeviceIdlabel = new Label();
            PushBulletTokenLabel = new Label();
            PushBulletTokenTextBox = new TextBox();
            ToastSettings = new GroupBox();
            GeneralSettings = new GroupBox();
            TestSettings = new GroupBox();
            _appTabControl.SuspendLayout();
            _mainTabPage.SuspendLayout();
            _mainTableLayout.SuspendLayout();
            _settingsPage.SuspendLayout();
            _settingsPanel.SuspendLayout();
            _settingsTableLayout.SuspendLayout();
            TtsSettings.SuspendLayout();
            TelegramSettings.SuspendLayout();
            DiscordSettings.SuspendLayout();
            PushBulletSettings.SuspendLayout();
            ToastSettings.SuspendLayout();
            GeneralSettings.SuspendLayout();
            TestSettings.SuspendLayout();
            SuspendLayout();
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.Location = new Point(3, 23);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.TabStop = false;
            LanguageLabel.Text = "Language";
            //
            // _languageValue
            //
            LanguageValue.Visible = false;
            LanguageValue.Name = "LanguageValue";
            LanguageValue.TabStop = false;
            // 
            // _languageComboBox
            // 
            LanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Location = new Point(90, 23);
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.Size = new Size(390, 25);
            LanguageComboBox.TabIndex = 0;
            // 
            // _flashTaskbar
            // 
            FlashTaskbar.AutoSize = true;
            FlashTaskbar.Location = new Point(6, 45);
            FlashTaskbar.Name = "FlashTaskbar";
            FlashTaskbar.TabIndex = 1;
            FlashTaskbar.Text = "Flash Taskbar when a Notification is received";
            FlashTaskbar.UseVisualStyleBackColor = true;
            //
            // _testConfigurationButton
            //
            TestConfigurationButton.AutoSize = true;
            TestConfigurationButton.Name = "TestConfigurationButton";
            TestConfigurationButton.Location = new Point(6, 68);
            TestConfigurationButton.MinimumSize = new Size(100, 25);
            TestConfigurationButton.TabIndex = 2;
            TestConfigurationButton.Text = "Test Configuration";
            TestConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // _disableToasts
            // 
            DisableToasts.AutoSize = true;
            DisableToasts.Location = new Point(6, 22);
            DisableToasts.Name = "DisableToasts";
            DisableToasts.TabIndex = 3;
            DisableToasts.Text = "Disable Toasts";
            DisableToasts.UseVisualStyleBackColor = true;
            // 
            // _persistToasts
            // 
            PersistToasts.AutoSize = true;
            PersistToasts.Location = new Point(6, 45);
            PersistToasts.Name = "PersistToasts";
            PersistToasts.TabIndex = 4;
            PersistToasts.Text = "Make Toasts Persistent";
            PersistToasts.UseVisualStyleBackColor = true;
            // 
            // _enableLegacyToast
            // 
            EnableActToast.AutoSize = true;
            EnableActToast.Location = new Point(6, 68);
            EnableActToast.Name = "EnableActToast";
            EnableActToast.TabIndex = 5;
            EnableActToast.Text = "Enable ACT Toasts";
            EnableActToast.UseVisualStyleBackColor = true;
            // 
            // _ttsCheckBox
            // 
            TtsCheckBox.AutoSize = true;
            TtsCheckBox.Location = new Point(6, 22);
            TtsCheckBox.Name = "TtsCheckBox";
            TtsCheckBox.TabIndex = 6;
            TtsCheckBox.Text = "Enable Text To Speech";
            TtsCheckBox.UseVisualStyleBackColor = true;
            // 
            // _ttsVoiceSelectionLabel
            // 
            TtsVoiceSelectionLabel.AutoSize = true;
            TtsVoiceSelectionLabel.Location = new Point(3, 45);
            TtsVoiceSelectionLabel.Name = "TtsVoiceSelectionLabel";
            TtsVoiceSelectionLabel.TabStop = false;
            TtsVoiceSelectionLabel.Text = "Selected Voice";
            // 
            // _ttsVoicesComboBox
            // 
            TtsVoicesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TtsVoicesComboBox.FormattingEnabled = true;
            TtsVoicesComboBox.Location = new Point(90, 45);
            TtsVoicesComboBox.Name = "TtsVoicesComboBox";
            TtsVoicesComboBox.Size = new Size(390, 25);
            TtsVoicesComboBox.TabIndex = 7;
            // 
            // _discordCheckBox
            // 
            DiscordCheckBox.AutoSize = true;
            DiscordCheckBox.Location = new Point(6, 22);
            DiscordCheckBox.Name = "DiscordCheckBox";
            DiscordCheckBox.TabIndex = 8;
            DiscordCheckBox.Size = new Size(390, 20);
            DiscordCheckBox.Text = "Enable Discord Notifications";
            DiscordCheckBox.UseVisualStyleBackColor = true;
            // 
            // _discordWebhookLabel
            // 
            DiscordWebhookLabel.AutoSize = true;
            DiscordWebhookLabel.Location = new Point(6, 45);
            DiscordWebhookLabel.Name = "DiscordWebhookLabel";
            DiscordWebhookLabel.Size = new Size(38, 13);
            DiscordWebhookLabel.TabStop = false;
            DiscordWebhookLabel.Text = "Webhook URL";
            // 
            // _discordWebhookTextBox
            // 
            DiscordWebhookTextBox.Location = new Point(90, 45);
            DiscordWebhookTextBox.Name = "DiscordWebhookTextBox";
            DiscordWebhookTextBox.Size = new Size(390, 20);
            DiscordWebhookTextBox.TabIndex = 9;
            // 
            // _discordUsernameLabel
            // 
            DiscordUsernameLabel.AutoSize = true;
            DiscordUsernameLabel.Location = new Point(6, 68);
            DiscordUsernameLabel.Name = "DiscordUsernameLabel";
            DiscordUsernameLabel.Size = new Size(41, 13);
            DiscordUsernameLabel.TabStop = false;
            DiscordUsernameLabel.Text = "Username";
            // 
            // _discordUsernameTextBox
            // 
            DiscordUsernameTextBox.Location = new Point(90, 68);
            DiscordUsernameTextBox.Name = "DiscordUsernameTextBox";
            DiscordUsernameTextBox.Size = new Size(390, 20);
            DiscordUsernameTextBox.TabIndex = 10;
            // 
            // _telegramCheckBox
            // 
            TelegramCheckBox.AutoSize = true;
            TelegramCheckBox.Location = new Point(6, 22);
            TelegramCheckBox.Name = "TelegramCheckBox";
            TelegramCheckBox.TabIndex = 11;
            TelegramCheckBox.Size = new Size(390, 20);
            TelegramCheckBox.Text = "Enable Telegram Notifications";
            TelegramCheckBox.UseVisualStyleBackColor = true;
            // 
            // _telegramTokenLabel
            // 
            TelegramTokenLabel.AutoSize = true;
            TelegramTokenLabel.Location = new Point(6, 45);
            TelegramTokenLabel.Name = "TelegramTokenLabel";
            TelegramTokenLabel.Size = new Size(38, 13);
            TelegramTokenLabel.TabStop = false;
            TelegramTokenLabel.Text = "Token";
            // 
            // _telegramTokenTextBox
            // 
            TelegramTokenTextBox.Location = new Point(90, 45);
            TelegramTokenTextBox.Name = "TelegramTokenTextBox";
            TelegramTokenTextBox.Size = new Size(390, 20);
            TelegramTokenTextBox.TabIndex = 12;
            // 
            // _telegramChatIdLabel
            // 
            TelegramChatIdLabel.AutoSize = true;
            TelegramChatIdLabel.Location = new Point(6, 68);
            TelegramChatIdLabel.Name = "TelegramChatIdLabel";
            TelegramChatIdLabel.Size = new Size(41, 13);
            TelegramChatIdLabel.TabStop = false;
            TelegramChatIdLabel.Text = "Chat Id";
            // 
            // _telegramChatIdTextBox
            // 
            TelegramChatIdTextBox.Location = new Point(90, 68);
            TelegramChatIdTextBox.Name = "TelegramChatIdTextBox";
            TelegramChatIdTextBox.Size = new Size(390, 20);
            TelegramChatIdTextBox.TabIndex = 13;
            // 
            // _pushbulletCheckbox
            // 
            PushBulletCheckbox.AutoSize = true;
            PushBulletCheckbox.Location = new Point(6, 22);
            PushBulletCheckbox.Name = "PushBulletCheckbox";
            PushBulletCheckbox.TabIndex = 14;
            PushBulletCheckbox.Size = new Size(390, 20);
            PushBulletCheckbox.Text = "Enable Pushbullet Notifications";
            PushBulletCheckbox.UseVisualStyleBackColor = true;
            // 
            // _pushbulletTokenLabel
            // 
            PushBulletTokenLabel.AutoSize = true;
            PushBulletTokenLabel.Location = new Point(6, 45);
            PushBulletTokenLabel.Name = "PushBulletTokenLabel";
            PushBulletTokenLabel.Size = new Size(76, 13);
            PushBulletTokenLabel.TabStop = false;
            PushBulletTokenLabel.Text = "Access Token";
            // 
            // _pushbulletTokenTextBox
            // 
            PushBulletTokenTextBox.Location = new Point(90, 45);
            PushBulletTokenTextBox.Name = "PushBulletTokenTextBox";
            PushBulletTokenTextBox.Size = new Size(390, 20);
            PushBulletTokenTextBox.TabIndex = 15;
            // 
            // _pushbulletDeviceIdlabel
            // 
            PushBulletDeviceIdlabel.AutoSize = true;
            PushBulletDeviceIdlabel.Location = new Point(6, 68);
            PushBulletDeviceIdlabel.Name = "PushBulletDeviceIdlabel";
            PushBulletDeviceIdlabel.Size = new Size(53, 13);
            PushBulletDeviceIdlabel.TabStop = false;
            PushBulletDeviceIdlabel.Text = "Device Id";
            // 
            // _pushbulletDeviceIdTextBox
            // 
            PushBulletDeviceIdTextBox.Location = new Point(90, 68);
            PushBulletDeviceIdTextBox.Name = "PushBulletDeviceIdTextBox";
            PushBulletDeviceIdTextBox.Size = new Size(390, 20);
            PushBulletDeviceIdTextBox.TabIndex = 16;
            // 
            // 
            // _enableTestEnvironment
            // 
            EnableTestEnvironment.AutoSize = true;
            EnableTestEnvironment.Location = new Point(6, 22);
            EnableTestEnvironment.Name = "EnableTestEnvironment";
            EnableTestEnvironment.TabIndex = 17;
            EnableTestEnvironment.Text = "Enable Test Environment";
            EnableTestEnvironment.UseVisualStyleBackColor = true;
            // 
            // _logLevelSelectionLabel
            // 
            LogLevelSelectionLabel.AutoSize = true;
            LogLevelSelectionLabel.Location = new Point(3, 45);
            LogLevelSelectionLabel.Name = "LogLevelSelectionLabel";
            LogLevelSelectionLabel.TabStop = false;
            LogLevelSelectionLabel.Text = "Selected Voice";
            // 
            // _logLevelComboBox
            // 
            LogLevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LogLevelComboBox.FormattingEnabled = true;
            LogLevelComboBox.Location = new Point(90, 45);
            LogLevelComboBox.Name = "LogLevelComboBox";
            LogLevelComboBox.Size = new Size(390, 25);
            LogLevelComboBox.TabIndex = 18;
            // 
            // _appTabControl
            //
            _appTabControl.Dock = DockStyle.Fill;
            _appTabControl.Controls.Add(_mainTabPage);
            _appTabControl.Controls.Add(_settingsPage);
            _appTabControl.Location = new Point(4, 4);
            _appTabControl.Name = "_appTabControl";
            _appTabControl.SelectedIndex = 0;
            _appTabControl.TabStop = false;
            // 
            // _mainTabPage
            // 
            _mainTabPage.Dock = DockStyle.Fill;
            _mainTabPage.Controls.Add(_mainTableLayout);
            _mainTabPage.Location = new Point(4, 22);
            _mainTabPage.Name = "_mainTabPage";
            _mainTabPage.Padding = new Padding(3);
            _mainTabPage.TabStop = false;
            _mainTabPage.Text = "Main";
            _mainTabPage.ToolTipText = "Shows main info and logs";
            _mainTabPage.UseVisualStyleBackColor = true;
            // 
            // _mainTableLayout
            // 
            _mainTableLayout.Dock = DockStyle.Fill;
            _mainTableLayout.ColumnCount = 4;
            _mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            _mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            _mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            _mainTableLayout.Controls.Add(ClearLogButton, 3, 0);
            _mainTableLayout.Controls.Add(LoggingRichTextBox, 0, 1);
            _mainTableLayout.Controls.Add(AppTitle, 0, 0);
            _mainTableLayout.Controls.Add(CopyrightLink, 1, 0);
            _mainTableLayout.Controls.Add(DonateLink, 2, 0);
            _mainTableLayout.Location = new Point(0, 3);
            _mainTableLayout.Name = "_mainTableLayout";
            _mainTableLayout.RowCount = 2;
            _mainTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _mainTableLayout.TabStop = false;
            // 
            // _button1
            // 
            ClearLogButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            ClearLogButton.Name = "ClearLogButton";
            ClearLogButton.MinimumSize = new Size(100, 25);
            ClearLogButton.TabIndex = 0;
            ClearLogButton.Text = "Clear Logs";
            ClearLogButton.UseVisualStyleBackColor = true;
            ClearLogButton.AutoSize = true;
            // 
            // _richTextBox1
            //
            LoggingRichTextBox.Dock = DockStyle.Fill;
            LoggingRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            _mainTableLayout.SetColumnSpan(LoggingRichTextBox, 4);
            LoggingRichTextBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoggingRichTextBox.Location = new Point(3, 32);
            LoggingRichTextBox.Name = "LoggingRichTextBox";
            LoggingRichTextBox.ReadOnly = true;
            LoggingRichTextBox.TabIndex = 1;
            LoggingRichTextBox.Text = "";
            // 
            // _appTitle
            // 
            AppTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            AppTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppTitle.Location = new Point(3, 0);
            AppTitle.Name = "AppTitle";
            AppTitle.TabStop = false;
            AppTitle.Text = "DFAssist ~";
            AppTitle.TextAlign = ContentAlignment.MiddleLeft;
            AppTitle.AutoSize = true;
            // 
            // _copyrightLink
            // 
            CopyrightLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            CopyrightLink.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CopyrightLink.LinkBehavior = LinkBehavior.HoverUnderline;
            CopyrightLink.Location = new Point(106, 0);
            CopyrightLink.Name = "CopyrightLink";
            CopyrightLink.TabIndex = 2;
            CopyrightLink.TabStop = true;
            CopyrightLink.Text = "© easly1989, ";
            CopyrightLink.TextAlign = ContentAlignment.MiddleLeft;
            CopyrightLink.AutoSize = true;
            // 
            // _donateLink
            // 
            DonateLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            DonateLink.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DonateLink.LinkBehavior = LinkBehavior.HoverUnderline;
            DonateLink.Location = new Point(106, 0);
            DonateLink.Name = "DonateLink";
            DonateLink.TabIndex = 3;
            DonateLink.TabStop = true;
            DonateLink.Text = "support me via PayPal!";
            DonateLink.TextAlign = ContentAlignment.MiddleLeft;
            DonateLink.AutoSize = true;
            // 
            // _settingsPage
            // 
            _settingsPage.Dock = DockStyle.Fill;
            _settingsPage.Controls.Add(_settingsPanel);
            _settingsPage.Location = new Point(4, 22);
            _settingsPage.Name = "_settingsPage";
            _settingsPage.Padding = new Padding(3);
            _settingsPage.TabStop = false;
            _settingsPage.Text = "Settings";
            _settingsPage.ToolTipText = "Change Settings for DFAssist";
            _settingsPage.UseVisualStyleBackColor = true;
            // 
            // _settingsPanel
            //
            _settingsPanel.Dock = DockStyle.Fill;
            _settingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            _settingsPanel.Controls.Add(_settingsTableLayout);
            _settingsPanel.Name = "_settingsPanel";
            _settingsPanel.TabStop = false;
            _settingsPanel.AutoScroll = true;
            // 
            // _settingsTableLayout
            // 
            _settingsTableLayout.Dock = DockStyle.Fill;
            _settingsTableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _settingsTableLayout.AutoSize = true;
            _settingsTableLayout.AutoSizeMode = AutoSizeMode.GrowOnly;
            _settingsTableLayout.ColumnCount = 1;
            _settingsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _settingsTableLayout.Controls.Add(GeneralSettings, 0, 0);
            _settingsTableLayout.Controls.Add(ToastSettings, 0, 1);
            _settingsTableLayout.Controls.Add(DiscordSettings, 0, 2);
            _settingsTableLayout.Controls.Add(TelegramSettings, 0, 3);
            _settingsTableLayout.Controls.Add(PushBulletSettings, 0, 4);
            _settingsTableLayout.Controls.Add(TtsSettings, 0, 5);
            _settingsTableLayout.Controls.Add(TestSettings, 0, 6);
            _settingsTableLayout.Location = new Point(0, 3);
            _settingsTableLayout.Name = "_settingsTableLayout";
            _settingsTableLayout.RowCount = 7;
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _settingsTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _settingsTableLayout.TabStop = false;
            // 
            // _generalSettings
            // 
            Dock = DockStyle.Top;
            GeneralSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GeneralSettings.Controls.Add(LanguageLabel);
            GeneralSettings.Controls.Add(LanguageComboBox);
            GeneralSettings.Controls.Add(FlashTaskbar);
            GeneralSettings.Controls.Add(TestConfigurationButton);
            GeneralSettings.Name = "GeneralSettings";
            GeneralSettings.TabStop = false;
            GeneralSettings.Text = "General Settings";
            // 
            // _toastSettings
            // 
            Dock = DockStyle.Top;
            ToastSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ToastSettings.Controls.Add(DisableToasts);
            ToastSettings.Controls.Add(EnableActToast);
            ToastSettings.Controls.Add(PersistToasts);
            ToastSettings.Name = "ToastSettings";
            ToastSettings.TabStop = false;
            ToastSettings.Text = "Toasts Settings";
            // 
            // _ttsSettings
            // 
            Dock = DockStyle.Top;
            TtsSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TtsSettings.Controls.Add(TtsCheckBox);
            TtsSettings.Controls.Add(TtsVoiceSelectionLabel);
            TtsSettings.Controls.Add(TtsVoicesComboBox);
            TtsSettings.Name = "TtsSettings";
            TtsSettings.TabStop = false;
            TtsSettings.Text = "Text To Speech Settings";
            // 
            // _discordSettings
            // 
            Dock = DockStyle.Top;
            DiscordSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DiscordSettings.Controls.Add(DiscordCheckBox);
            DiscordSettings.Controls.Add(DiscordWebhookLabel);
            DiscordSettings.Controls.Add(DiscordWebhookTextBox);
            DiscordSettings.Controls.Add(DiscordUsernameLabel);
            DiscordSettings.Controls.Add(DiscordUsernameTextBox);
            DiscordSettings.Name = "DiscordSettings";
            DiscordSettings.TabStop = false;
            DiscordSettings.Text = "Discord Settings";
            // 
            // _telegramSettings
            // 
            Dock = DockStyle.Top;
            TelegramSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TelegramSettings.Controls.Add(TelegramCheckBox);
            TelegramSettings.Controls.Add(TelegramTokenLabel);
            TelegramSettings.Controls.Add(TelegramTokenTextBox);
            TelegramSettings.Controls.Add(TelegramChatIdLabel);
            TelegramSettings.Controls.Add(TelegramChatIdTextBox);
            TelegramSettings.Name = "TelegramSettings";
            TelegramSettings.TabStop = false;
            TelegramSettings.Text = "Telegram Settings";
            // 
            // _pushBulletSettings
            // 
            Dock = DockStyle.Top;
            PushBulletSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PushBulletSettings.Controls.Add(PushBulletDeviceIdTextBox);
            PushBulletSettings.Controls.Add(PushBulletDeviceIdlabel);
            PushBulletSettings.Controls.Add(PushBulletTokenTextBox);
            PushBulletSettings.Controls.Add(PushBulletTokenLabel);
            PushBulletSettings.Controls.Add(PushBulletCheckbox);
            PushBulletSettings.Name = "PushBulletSettings";
            PushBulletSettings.TabStop = false;
            PushBulletSettings.Text = "PushBullet Settings";
            // 
            // _testSettings
            // 
            Dock = DockStyle.Top;
            TestSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TestSettings.Controls.Add(EnableTestEnvironment);
            TestSettings.Controls.Add(LogLevelSelectionLabel);
            TestSettings.Controls.Add(LogLevelComboBox);
            TestSettings.Name = "TestSettings";
            TestSettings.TabStop = false;
            TestSettings.Text = "Test Settings";
            // 
            // MainControl
            // 
            Dock = DockStyle.Fill;
            Controls.Add(_appTabControl);
            Name = "MainControl";
            _appTabControl.ResumeLayout(false);
            _mainTabPage.ResumeLayout(false);
            _mainTableLayout.ResumeLayout(false);
            _mainTableLayout.PerformLayout();
            _settingsPage.ResumeLayout(false);
            _settingsPage.PerformLayout();
            _settingsPanel.ResumeLayout(false);
            _settingsPanel.PerformLayout();
            _settingsTableLayout.ResumeLayout(false);
            _settingsTableLayout.PerformLayout();
            TtsSettings.ResumeLayout(false);
            TtsSettings.PerformLayout();
            ToastSettings.ResumeLayout(false);
            ToastSettings.PerformLayout();
            GeneralSettings.ResumeLayout(false);
            GeneralSettings.PerformLayout();
            TestSettings.ResumeLayout(false);
            TestSettings.PerformLayout();
            ResumeLayout(false);
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            DFAssistPlugin.Instance.InitPlugin(this);
        }

        public void DeInitPlugin()
        {
            DFAssistPlugin.Instance.DeInitPlugin();
        }
    }
}