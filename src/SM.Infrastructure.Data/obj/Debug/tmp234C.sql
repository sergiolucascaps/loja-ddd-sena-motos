CREATE TABLE [dbo].[Tab_Categoria] (
    [Idf_Categoria] [uniqueidentifier] NOT NULL,
    [Des_Titulo_Categoria] [varchar](75) NOT NULL,
    [Des_Categoria] [varchar](400),
    CONSTRAINT [PK_dbo.Tab_Categoria] PRIMARY KEY ([Idf_Categoria])
)
CREATE TABLE [dbo].[Tab_Usuario] (
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    [Nme_Usuario] [varchar](100) NOT NULL,
    [Num_Cpf] [varchar](11) NOT NULL,
    [Des_Senha] [varchar](100) NOT NULL,
    [Des_Senha_Hash] [varchar](100) NOT NULL,
    [Dta_Nascimento] [datetime] NOT NULL,
    [Dta_Criacao] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Usuario] PRIMARY KEY ([Idf_Usuario])
)
CREATE TABLE [dbo].[Tab_Contato] (
    [Idf_Contato] [uniqueidentifier] NOT NULL,
    [Des_Eml_Contato] [varchar](254),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Ultima_Alteracao] [datetime] NOT NULL,
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Contato] PRIMARY KEY ([Idf_Contato])
)
CREATE TABLE [dbo].[Tab_Endereco] (
    [Idf_Endereco] [uniqueidentifier] NOT NULL,
    [Nme_Endereco] [varchar](100),
    [Des_Logradouro] [varchar](100) NOT NULL,
    [Des_Numero] [varchar](100),
    [Des_Complemento] [varchar](256),
    [Des_Bairro] [varchar](100),
    [Num_Cep] [varchar](100),
    [Des_Cidade] [varchar](75) NOT NULL,
    [Des_Estado] [varchar](2),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime] NOT NULL,
    [Idf_Contato] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Endereco] PRIMARY KEY ([Idf_Endereco])
)
CREATE TABLE [dbo].[Tab_Telefone] (
    [Idf_Telefone] [uniqueidentifier] NOT NULL,
    [Num_DDD] [varchar](100) NOT NULL,
    [Num_Telefone] [varchar](100),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Idf_Contato] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Telefone] PRIMARY KEY ([Idf_Telefone])
)
CREATE TABLE [dbo].[Tab_Usuario_Imagem] (
    [Idf_Imagem] [uniqueidentifier] NOT NULL,
    [Imagem] [varbinary](max),
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Usuario_Imagem] PRIMARY KEY ([Idf_Imagem])
)
CREATE TABLE [dbo].[Tab_Usuario_Categoria] (
    [Categoria_Idf_Categoria] [uniqueidentifier] NOT NULL,
    [Usuario_Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Usuario_Categoria] PRIMARY KEY ([Categoria_Idf_Categoria], [Usuario_Idf_Usuario])
)
CREATE UNIQUE INDEX [IX_Num_Cpf] ON [dbo].[Tab_Usuario]([Num_Cpf])
CREATE INDEX [IX_Idf_Usuario] ON [dbo].[Tab_Contato]([Idf_Usuario])
CREATE INDEX [IX_Idf_Contato] ON [dbo].[Tab_Endereco]([Idf_Contato])
CREATE INDEX [IX_Idf_Contato] ON [dbo].[Tab_Telefone]([Idf_Contato])
CREATE INDEX [IX_Idf_Usuario] ON [dbo].[Tab_Usuario_Imagem]([Idf_Usuario])
CREATE INDEX [IX_Categoria_Idf_Categoria] ON [dbo].[Tab_Usuario_Categoria]([Categoria_Idf_Categoria])
CREATE INDEX [IX_Usuario_Idf_Usuario] ON [dbo].[Tab_Usuario_Categoria]([Usuario_Idf_Usuario])
ALTER TABLE [dbo].[Tab_Contato] ADD CONSTRAINT [FK_dbo.Tab_Contato_dbo.Tab_Usuario_Idf_Usuario] FOREIGN KEY ([Idf_Usuario]) REFERENCES [dbo].[Tab_Usuario] ([Idf_Usuario])
ALTER TABLE [dbo].[Tab_Endereco] ADD CONSTRAINT [FK_dbo.Tab_Endereco_dbo.Tab_Contato_Idf_Contato] FOREIGN KEY ([Idf_Contato]) REFERENCES [dbo].[Tab_Contato] ([Idf_Contato])
ALTER TABLE [dbo].[Tab_Telefone] ADD CONSTRAINT [FK_dbo.Tab_Telefone_dbo.Tab_Contato_Idf_Contato] FOREIGN KEY ([Idf_Contato]) REFERENCES [dbo].[Tab_Contato] ([Idf_Contato])
ALTER TABLE [dbo].[Tab_Usuario_Imagem] ADD CONSTRAINT [FK_dbo.Tab_Usuario_Imagem_dbo.Tab_Usuario_Idf_Usuario] FOREIGN KEY ([Idf_Usuario]) REFERENCES [dbo].[Tab_Usuario] ([Idf_Usuario])
ALTER TABLE [dbo].[Tab_Usuario_Categoria] ADD CONSTRAINT [FK_dbo.Tab_Usuario_Categoria_dbo.Tab_Categoria_Categoria_Idf_Categoria] FOREIGN KEY ([Categoria_Idf_Categoria]) REFERENCES [dbo].[Tab_Categoria] ([Idf_Categoria])
ALTER TABLE [dbo].[Tab_Usuario_Categoria] ADD CONSTRAINT [FK_dbo.Tab_Usuario_Categoria_dbo.Tab_Usuario_Usuario_Idf_Usuario] FOREIGN KEY ([Usuario_Idf_Usuario]) REFERENCES [dbo].[Tab_Usuario] ([Idf_Usuario])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201707190009211_AutomaticMigration', N'SM.Infrastructure.Data.Migrations.Configuration',  0x1F8B0800000000000400D55DDD6EE3B815BE2FD0771074D516D9D899FDE936B07731E324BBC14E92C5D859F42E6024DA11AA1FAF4405098A3ED95EF491FA0AA5648992481E9A9418CBC1DCCC88E2C7C3C38F878747E778FEF7C77F673FBE44A1F38CD32C48E2B97B763A751D1C7B891FC49BB99B93F557DFBB3FFEF0E73FCD2EFDE8C5F9AD7EEFEBE23DDA33CEE6EE1321DBF3C924F39E7084B2D328F0D2244BD6E4D44BA209F293C987E9F41F93B3B309A6102EC5729CD9973C264184CB7FD07F2E92D8C35B92A3F026F1719855CF69CBB244756E5184B32DF2F0DC5DDE9C5EC7EB146524CD3D92A7F8F40211744A21087E21AEF3310C10956A89C3B5EBA0384E082254E6F3FB0C2F499AC49BE5963E40E1EA758BE97B6B1466B89ACB79F3BAEEB4A61F8A694D9A8E3594976724890C01CFBEAEF434E1BBF7D2B6CBF448357949354E5E8B5997DA9CBB0B44F0264903E43AFC68E78B302DDE2CB57D415B82F8B4EC1FE0EC94F53B7158EB09A3066550F1E7C459E461B13AF318E72445E189F36BFE1806DE2FF87595FC0BC7F3380FC3B6805444DAD679401FFD9A265B9C92D72F785D897DEDAF1F5AA24FBA10131E8321C8BBEF66F9531EF8AE734B25428F2166A49828912E70F6B00A481E262220651ADD40AE73835E3EE378439EE6EEDFBF759DABE005FBF5836A90FB38A0DB8DF6A17CC6BD84D019FD9BE9546B786EB45BF41C6C4A4A70E3DE67394A8324739D2F382C5FC89E82ED6EDB350C79685EBB4A93E84B12B679C75A1F96499E7A74F45502BEB242E90693AE80B349436A25D52B1443A257BDC6A33913BB0FC959E70114BF8D308F23E1D69926B74C07CFA387C576AD1AF88C1B7737CEF01DB5C4F1936A37BDD18CD9D00F3FA3EC6984F1097AB84599474FE698B015A7C72B5ED147BDE01674137BC80ED6C790E0B41F1A68C798A5B164C96A33A5B064B5B1EB65C90A370711534B56F51AF1C0AEC5EE755CD79D071ED69751C86349F6D6876FBFE97352CAB88FFCC24BB543FEFB903ACC83F680AD3302DC4B97B18F53EC014E41DDDA2C41B391F836611B092FC836914AB6150EF13A89B15CB6BA55261BDF26C826BC602A1B5B059901AA30D93B2DEBD36D129D28AE7D9007552F80A1E1A9BB8D67791AC1FB989EA6F7402F8A071A70A8EF37749F934D4AAF82793A82D7568C4F3D376C656C8DBB4F126D43DCF157A436FD3B4BE37D42417A80A995BE2FDE1E4685818F7C3CCACDF5322394A7AA853BC6A3D8EE19DCCBBB81FDD91A6DE809CC9F26E011DDEB38A9CF4CC3E3A4EE36DE71D208DEE738697A0F394EA86DB8B8B818E742CECFE0ED2C93CD5D7BD87D66E44DF2FB0C74378704BEAE23B4C151BFF0D7AEEF783BAE96BDCF7EABFB0ED86D5D884F418CD2D70EDDE95FE5743FF4F54B758DE8ACA5EC32217D4120A7FC2D13867ECCB2C40B4AF1F8084C1362E94E989E3CCEFEC8F18EC59D980D5D26CACB604B99482599BB7F1374A98466F7BC069A294E093C9BB466A99EBC702443F2C1E773235D73C7D09F377CF36E29B436635DD83301966E5C0A16175FD7681F6AB9A9B520E22E0F622FD8A2708F045C3FD3D052B10C6C28BEE5026F311D36267BB46B4106361467BEF6E9CA8044C279032D367CF8348BDD1CF0FA2482432487221124C121490469F77D90880F348186128A3AED5D6AA5F9056255FB6DAF25020102E8AE1DF0A5CE883F80662D887000FAC81D0C68B9F7781BC2A2D74E983EA1D49ECAC168A514E390E4526AFC1829B6731FCB3D11C438ADA458E218DD2424C958BA8F70A5B9CF7075ABC9AA9B26CF91027889497D7AA2C7760645E3B68AEEA4C0361189A948C0813EE64BE5A92DA8280DF0214D86D2F883020C181597E1342E818003864314BA61B7324845C08DAF45940657F681B6F522FC199767B0D62D83CD4AA08DB023B4AE161C1E98EFD19DBA865AC4509FA814F5DD43EFF6C14D00A295DE9583D72EF4CDD8581B624046D486DA89D673A3B909409B43CF777E336D089F1425FB45E50C6AB9837AD26BF9806FB64980A088A80E0DE7C6C0BD91CF07887319383583F554C76CD8A1CBDA66935D1E6EF56036011276673768BB0DE24D2B81B77AE22C77D9BB8BAF96E6A9ACD10E63E265928C56262D1B8924295510D75AF0CBC757419A91225FF81115A1B5851F09AF092E0670B0D5C3C9BC087109EB93AEEE55FCBD726994F9CCA72068A3DB2B3ADDE20B683973DCA281A2AF53A456A310A5EAF4D84512E651AC9178ABC29427CAB6A1E56F988DA0805662CE269C1A05DF56583D6E43F194D0260C6C497AD30580D4200BD8534515666478A280570518AF936CDAC6EB3418E0D5F9A31DACFAA119B9AA84509E58D5E31E585586A714B06A3340E5F2363BA85C9B192A4BDFE4215983195EEBD3398FD86A3AAA4D0AFB83FD6DBA1C52C7A2433D95F6BC76BE046B0E79658A45E4F3287906771A0DC9C63EF70A6C632D668862D2248F2CBEA13F425F03382299D905CD229B214C0D3AC35D553A6F6E99BCD2E1FB278CD8CDCEE3CF9D3E887C0A1EBF45DA6D66A875621D8F583F37F498DAB97382CFD46E34C3AD73E478C8FAB9E1115EA4C1094778F1D070B6559A9B30D1EAB9A10DAC32D704F3573D1FDBF2F53D686D9F2323DA3A167EB168EB204C0D5B077755E9BC8921F14A87A34B30224B1DE3F753F9D00C472E59B765CC5DF00E19CB8582EC5F0BE5C0FA9743A8BF6A0DEAB816BF0450BC4B81264332473952AFAD1B96EB9243F695C33C82D4EA0C468A14C14DA8724EF84C22AACE34D4D460EF093A154A6582F59219FC166B461EB675D59F492169F9A8ACC8102138CBBFC2F8C982B45C3076560546F7FFC4821029DDBDE23A54F6E7C02FA3A4AF19C1D18E68CBDFC34518D01DD1BC7083E2608D33B24BFF743F4CA7DF73BFCC703CBF9230C9323F940496A53F95D05DB5D17EB0208F83DF731C141FDC83758053AB3F5EF08C52EF09A5420D888D9F26906197BF4DD0808BD9E1C675FE3D57C966BDFDE01592D4DECB9477D6555E9FCA7A062BE4525CD3DBEFCBDCFDB7739DDD97F339775674759CFF0865F8438BEC6D4D4D5E426F0D5D5A20EF5392134B05F283B084C2244D34E3EAF3BE56D06215B8150B28A9089751A52C095719286069B9F295416B0BD57FF706D5B259B0452840CE9DEB7FB63D9E13E72EA587FFB9332D2C841DCAC9438463D5FF5AB1EA3CA88675EA5FF96BD3B076EB7A2D8A2DA9E295EFC3EFFAA0776B762D89CD55E8DA5446A71ED7A233D6ADB6952A78743367D7BEED3D3334ED1BFBFD14FBF64D1E161CAB2075B87DEB16A7DAF45879596D6D399B147E27A45384F3C628CC1CCCBA2E1C25C66359A7F99708BDFCD5940FEFC42F5247ECF456513FCC26F6D50878EDA70228C000BD0398066B20CA299DEC001925781638A2535B2B8DD1CA92D5F54A6AC532190914FF0B821D44BD925AA76F5997227BD23052E718D572ED89A70FDC8E072908D48B958BE9C9FDCAAB8E8B3726CB66ADFEAF0F6734BF3B1C802FDAA5ECFC4FF01955078B65243D4BE08754898E529BFE4EEA88B58BD12DD140F8411AB322F677430345E6C931D240B79CDCD699A14FA6F77C4218F2EE1D96840F25025742DABF94FCDD90625F6ACFF8D49097728BE558FC9A762B88356BB477A90A73D77F2CB8B4BB43296B758581344AB8A141746BBC35EABBC1796816806B157F4383E89787EB948643A368178F735B775FDDF89ED581025720E1604288AFEC1B1BA6A166793B2B23D5A9720732B2E4F77D69E1A056613BA72079469985C265B8905E4B19F2542FD91924298B3B264558AEEEE7AC51A7D048A790BFD311FEDE3A76D97EDF69F236AE9BCD7D64F5F8BD29ACAF9C23ACB4379EAEF44491643ABF49F1BC9887499DABD67F88455DBC2CD83410C57F8F1563AFE356B177AEE37552BB789C44F52B5C30FB0613E4539FEB634A8235F2086DF67096953FE3FA1B0AF36267478FD8BF8EEF72B2CD099D328E1EC3D7B6320A2F51357EF90B015D996777DBF247296D4C818A1914DFE8EEE24F7910FA4CEE2B49B01C8028DCCF9F307DBE5B4BEACD5233FDCA906E85BD0D0155EA635EF30A47DB90826577F1123DE33EB2DD67F833DE20EFB54EA78541F62F4457EDB38B006D5214651546D39FFE9372D88F5E7EF83F43F5EDB3176E0000 , N'6.1.3-40302')

