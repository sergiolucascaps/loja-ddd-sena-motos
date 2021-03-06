CREATE TABLE [dbo].[Tab_Anuncio] (
    [Idf_Anuncio] [uniqueidentifier] NOT NULL,
    [Des_Titulo_Anuncio] [varchar](75) NOT NULL,
    [Des_Anuncio] [varchar](500),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime],
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Anuncio] PRIMARY KEY ([Idf_Anuncio])
)
CREATE TABLE [dbo].[Tab_Produto] (
    [Idf_Produto] [uniqueidentifier] NOT NULL,
    [Des_Nme_Produto] [varchar](75) NOT NULL,
    [Des_Produto] [varchar](100),
    [Vlr_Produto] [decimal](18, 2),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime],
    [Idf_Anuncio] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Produto] PRIMARY KEY ([Idf_Produto])
)
CREATE TABLE [dbo].[Tab_Categoria] (
    [Idf_Categoria] [uniqueidentifier] NOT NULL,
    [Des_Titulo_Categoria] [varchar](75) NOT NULL,
    [Des_Categoria] [varchar](400),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime],
    CONSTRAINT [PK_dbo.Tab_Categoria] PRIMARY KEY ([Idf_Categoria])
)
CREATE TABLE [dbo].[Tab_Usuario] (
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    [Nme_Usuario] [varchar](100) NOT NULL,
    [Num_Cpf] [varchar](11) NOT NULL,
    [Des_Senha] [varchar](100) NOT NULL,
    [Des_Senha_Hash] [varchar](100) NOT NULL,
    [Dta_Nascimento] [datetime] NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime] NOT NULL,
    [Contato_Idf_Contato] [uniqueidentifier],
    CONSTRAINT [PK_dbo.Tab_Usuario] PRIMARY KEY ([Idf_Usuario])
)
CREATE TABLE [dbo].[Tab_Contato] (
    [Idf_Contato] [uniqueidentifier] NOT NULL,
    [Des_Eml_Contato] [varchar](254),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime] NOT NULL,
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
    [Dta_Alteracao] [datetime],
    [Idf_Contato] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Endereco] PRIMARY KEY ([Idf_Endereco])
)
CREATE TABLE [dbo].[Tab_Telefone] (
    [Idf_Telefone] [uniqueidentifier] NOT NULL,
    [Num_DDD] [varchar](100) NOT NULL,
    [Num_Telefone] [varchar](100),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime],
    [Idf_Contato] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Telefone] PRIMARY KEY ([Idf_Telefone])
)
CREATE TABLE [dbo].[Tab_Negociacao] (
    [Idf_Negociacao] [uniqueidentifier] NOT NULL,
    [Des_Negociacao] [varchar](75),
    [Idf_Status_Negociacao] [int] NOT NULL,
    [Dta_Inicio_Negociacao] [datetime] NOT NULL,
    [Dta_Fim_Negociacao] [datetime] NOT NULL,
    [Idf_Anuncio] [uniqueidentifier] NOT NULL,
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Negociacao] PRIMARY KEY ([Idf_Negociacao])
)
CREATE TABLE [dbo].[Tab_Status_Negociacao] (
    [Idf_Status_Negociacao] [int] NOT NULL,
    [Des_Status_Negociacao] [varchar](75) NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Status_Negociacao] PRIMARY KEY ([Idf_Status_Negociacao])
)
CREATE TABLE [dbo].[Tab_Produto_Imagem] (
    [Idf_Imagem] [uniqueidentifier] NOT NULL,
    [Imagem] [varbinary](max),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime],
    [Idf_Produto] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Produto_Imagem] PRIMARY KEY ([Idf_Imagem])
)
CREATE TABLE [dbo].[Tab_Entrega] (
    [Idf_Entrega] [uniqueidentifier] NOT NULL,
    [Des_Iteracao_Entrega] [varchar](500) NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    [Idf_Status_Entrega] [int] NOT NULL,
    [Idf_Venda] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Entrega] PRIMARY KEY ([Idf_Entrega])
)
CREATE TABLE [dbo].[Tab_Status_Entrega] (
    [Idf_Status_Entrega] [int] NOT NULL IDENTITY,
    [Des_Status_Entrega] [varchar](75) NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Status_Entrega] PRIMARY KEY ([Idf_Status_Entrega])
)
CREATE TABLE [dbo].[Tab_Venda] (
    [Idf_Venda] [uniqueidentifier] NOT NULL,
    [Qtd_Produtos] [int] NOT NULL,
    [Vlr_Final_Venda] [decimal](18, 2),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Idf_Negociacao] [uniqueidentifier] NOT NULL,
    [Idf_Status_Venda] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Venda] PRIMARY KEY ([Idf_Venda])
)
CREATE TABLE [dbo].[Tab_Status_Venda] (
    [Idf_Status_Venda] [int] NOT NULL,
    [Des_Status_Venda] [varchar](75) NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Status_Venda] PRIMARY KEY ([Idf_Status_Venda])
)
CREATE TABLE [dbo].[Tab_Entrega_Historico] (
    [Idf_Entrega_Historico] [uniqueidentifier] NOT NULL,
    [Des_Iteracao_Entrega_Historico] [varchar](500) NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    [Idf_Status_Entrega] [int] NOT NULL,
    [Idf_Entrega] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Entrega_Historico] PRIMARY KEY ([Idf_Entrega_Historico])
)
CREATE TABLE [dbo].[Tab_Negociacao_Chat] (
    [Idf_Chat] [uniqueidentifier] NOT NULL,
    [Des_Mensagem_Chat] [varchar](500) NOT NULL,
    [Dta_Cadastro] [datetime] NOT NULL,
    [Idf_Negociacao] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Negociacao_Chat] PRIMARY KEY ([Idf_Chat])
)
CREATE TABLE [dbo].[Tab_Usuario_Imagem] (
    [Idf_Imagem] [uniqueidentifier] NOT NULL,
    [Imagem] [varbinary](max),
    [Dta_Cadastro] [datetime] NOT NULL,
    [Dta_Alteracao] [datetime],
    [Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Usuario_Imagem] PRIMARY KEY ([Idf_Imagem])
)
CREATE TABLE [dbo].[Tab_Produto_Categoria] (
    [Categoria_Idf_Categoria] [uniqueidentifier] NOT NULL,
    [Produto_Idf_Produto] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Produto_Categoria] PRIMARY KEY ([Categoria_Idf_Categoria], [Produto_Idf_Produto])
)
CREATE TABLE [dbo].[Tab_Usuario_Categoria] (
    [Categoria_Idf_Categoria] [uniqueidentifier] NOT NULL,
    [Usuario_Idf_Usuario] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Tab_Usuario_Categoria] PRIMARY KEY ([Categoria_Idf_Categoria], [Usuario_Idf_Usuario])
)
CREATE INDEX [IX_Idf_Usuario] ON [dbo].[Tab_Anuncio]([Idf_Usuario])
CREATE INDEX [IX_Idf_Anuncio] ON [dbo].[Tab_Produto]([Idf_Anuncio])
CREATE INDEX [IX_Idf_Usuario] ON [dbo].[Tab_Usuario]([Idf_Usuario])
CREATE UNIQUE INDEX [IX_Num_Cpf] ON [dbo].[Tab_Usuario]([Num_Cpf])
CREATE INDEX [IX_Contato_Idf_Contato] ON [dbo].[Tab_Usuario]([Contato_Idf_Contato])
CREATE INDEX [IX_Idf_Contato] ON [dbo].[Tab_Endereco]([Idf_Contato])
CREATE INDEX [IX_Idf_Contato] ON [dbo].[Tab_Telefone]([Idf_Contato])
CREATE INDEX [IX_Idf_Status_Negociacao] ON [dbo].[Tab_Negociacao]([Idf_Status_Negociacao])
CREATE INDEX [IX_Idf_Anuncio] ON [dbo].[Tab_Negociacao]([Idf_Anuncio])
CREATE INDEX [IX_Idf_Usuario] ON [dbo].[Tab_Negociacao]([Idf_Usuario])
CREATE UNIQUE INDEX [IX_Idf_Status_Negociacao] ON [dbo].[Tab_Status_Negociacao]([Idf_Status_Negociacao])
CREATE INDEX [IX_Idf_Produto] ON [dbo].[Tab_Produto_Imagem]([Idf_Produto])
CREATE INDEX [IX_Idf_Status_Entrega] ON [dbo].[Tab_Entrega]([Idf_Status_Entrega])
CREATE INDEX [IX_Idf_Venda] ON [dbo].[Tab_Entrega]([Idf_Venda])
CREATE INDEX [IX_Idf_Negociacao] ON [dbo].[Tab_Venda]([Idf_Negociacao])
CREATE INDEX [IX_Idf_Status_Venda] ON [dbo].[Tab_Venda]([Idf_Status_Venda])
CREATE UNIQUE INDEX [IX_Idf_Status_Venda] ON [dbo].[Tab_Status_Venda]([Idf_Status_Venda])
CREATE INDEX [IX_Idf_Entrega] ON [dbo].[Tab_Entrega_Historico]([Idf_Entrega])
CREATE INDEX [IX_Idf_Negociacao] ON [dbo].[Tab_Negociacao_Chat]([Idf_Negociacao])
CREATE INDEX [IX_Idf_Usuario] ON [dbo].[Tab_Usuario_Imagem]([Idf_Usuario])
CREATE INDEX [IX_Categoria_Idf_Categoria] ON [dbo].[Tab_Produto_Categoria]([Categoria_Idf_Categoria])
CREATE INDEX [IX_Produto_Idf_Produto] ON [dbo].[Tab_Produto_Categoria]([Produto_Idf_Produto])
CREATE INDEX [IX_Categoria_Idf_Categoria] ON [dbo].[Tab_Usuario_Categoria]([Categoria_Idf_Categoria])
CREATE INDEX [IX_Usuario_Idf_Usuario] ON [dbo].[Tab_Usuario_Categoria]([Usuario_Idf_Usuario])
ALTER TABLE [dbo].[Tab_Anuncio] ADD CONSTRAINT [FK_dbo.Tab_Anuncio_dbo.Tab_Usuario_Idf_Usuario] FOREIGN KEY ([Idf_Usuario]) REFERENCES [dbo].[Tab_Usuario] ([Idf_Usuario])
ALTER TABLE [dbo].[Tab_Produto] ADD CONSTRAINT [FK_dbo.Tab_Produto_dbo.Tab_Anuncio_Idf_Anuncio] FOREIGN KEY ([Idf_Anuncio]) REFERENCES [dbo].[Tab_Anuncio] ([Idf_Anuncio])
ALTER TABLE [dbo].[Tab_Usuario] ADD CONSTRAINT [FK_dbo.Tab_Usuario_dbo.Tab_Contato_Idf_Usuario] FOREIGN KEY ([Idf_Usuario]) REFERENCES [dbo].[Tab_Contato] ([Idf_Contato])
ALTER TABLE [dbo].[Tab_Usuario] ADD CONSTRAINT [FK_dbo.Tab_Usuario_dbo.Tab_Contato_Contato_Idf_Contato] FOREIGN KEY ([Contato_Idf_Contato]) REFERENCES [dbo].[Tab_Contato] ([Idf_Contato])
ALTER TABLE [dbo].[Tab_Endereco] ADD CONSTRAINT [FK_dbo.Tab_Endereco_dbo.Tab_Contato_Idf_Contato] FOREIGN KEY ([Idf_Contato]) REFERENCES [dbo].[Tab_Contato] ([Idf_Contato])
ALTER TABLE [dbo].[Tab_Telefone] ADD CONSTRAINT [FK_dbo.Tab_Telefone_dbo.Tab_Contato_Idf_Contato] FOREIGN KEY ([Idf_Contato]) REFERENCES [dbo].[Tab_Contato] ([Idf_Contato])
ALTER TABLE [dbo].[Tab_Negociacao] ADD CONSTRAINT [FK_dbo.Tab_Negociacao_dbo.Tab_Anuncio_Idf_Anuncio] FOREIGN KEY ([Idf_Anuncio]) REFERENCES [dbo].[Tab_Anuncio] ([Idf_Anuncio])
ALTER TABLE [dbo].[Tab_Negociacao] ADD CONSTRAINT [FK_dbo.Tab_Negociacao_dbo.Tab_Status_Negociacao_Idf_Status_Negociacao] FOREIGN KEY ([Idf_Status_Negociacao]) REFERENCES [dbo].[Tab_Status_Negociacao] ([Idf_Status_Negociacao])
ALTER TABLE [dbo].[Tab_Negociacao] ADD CONSTRAINT [FK_dbo.Tab_Negociacao_dbo.Tab_Usuario_Idf_Usuario] FOREIGN KEY ([Idf_Usuario]) REFERENCES [dbo].[Tab_Usuario] ([Idf_Usuario])
ALTER TABLE [dbo].[Tab_Produto_Imagem] ADD CONSTRAINT [FK_dbo.Tab_Produto_Imagem_dbo.Tab_Produto_Idf_Produto] FOREIGN KEY ([Idf_Produto]) REFERENCES [dbo].[Tab_Produto] ([Idf_Produto])
ALTER TABLE [dbo].[Tab_Entrega] ADD CONSTRAINT [FK_dbo.Tab_Entrega_dbo.Tab_Status_Entrega_Idf_Status_Entrega] FOREIGN KEY ([Idf_Status_Entrega]) REFERENCES [dbo].[Tab_Status_Entrega] ([Idf_Status_Entrega])
ALTER TABLE [dbo].[Tab_Entrega] ADD CONSTRAINT [FK_dbo.Tab_Entrega_dbo.Tab_Venda_Idf_Venda] FOREIGN KEY ([Idf_Venda]) REFERENCES [dbo].[Tab_Venda] ([Idf_Venda])
ALTER TABLE [dbo].[Tab_Venda] ADD CONSTRAINT [FK_dbo.Tab_Venda_dbo.Tab_Negociacao_Idf_Negociacao] FOREIGN KEY ([Idf_Negociacao]) REFERENCES [dbo].[Tab_Negociacao] ([Idf_Negociacao])
ALTER TABLE [dbo].[Tab_Venda] ADD CONSTRAINT [FK_dbo.Tab_Venda_dbo.Tab_Status_Venda_Idf_Status_Venda] FOREIGN KEY ([Idf_Status_Venda]) REFERENCES [dbo].[Tab_Status_Venda] ([Idf_Status_Venda])
ALTER TABLE [dbo].[Tab_Entrega_Historico] ADD CONSTRAINT [FK_dbo.Tab_Entrega_Historico_dbo.Tab_Entrega_Idf_Entrega] FOREIGN KEY ([Idf_Entrega]) REFERENCES [dbo].[Tab_Entrega] ([Idf_Entrega])
ALTER TABLE [dbo].[Tab_Negociacao_Chat] ADD CONSTRAINT [FK_dbo.Tab_Negociacao_Chat_dbo.Tab_Negociacao_Idf_Negociacao] FOREIGN KEY ([Idf_Negociacao]) REFERENCES [dbo].[Tab_Negociacao] ([Idf_Negociacao])
ALTER TABLE [dbo].[Tab_Usuario_Imagem] ADD CONSTRAINT [FK_dbo.Tab_Usuario_Imagem_dbo.Tab_Usuario_Idf_Usuario] FOREIGN KEY ([Idf_Usuario]) REFERENCES [dbo].[Tab_Usuario] ([Idf_Usuario])
ALTER TABLE [dbo].[Tab_Produto_Categoria] ADD CONSTRAINT [FK_dbo.Tab_Produto_Categoria_dbo.Tab_Categoria_Categoria_Idf_Categoria] FOREIGN KEY ([Categoria_Idf_Categoria]) REFERENCES [dbo].[Tab_Categoria] ([Idf_Categoria])
ALTER TABLE [dbo].[Tab_Produto_Categoria] ADD CONSTRAINT [FK_dbo.Tab_Produto_Categoria_dbo.Tab_Produto_Produto_Idf_Produto] FOREIGN KEY ([Produto_Idf_Produto]) REFERENCES [dbo].[Tab_Produto] ([Idf_Produto])
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
VALUES (N'201707281726443_AutomaticMigration', N'SM.Infrastructure.Data.Migrations.Configuration',  0x1F8B0800000000000400ED5D5F731BB9917FBFAA7C07169FEE528E2879D7C9C62525E595EC5D5556B6CF92B7F2A61A93903495E1909919BAA4BABA4F96877CA4FB0A8719CE1F00DD8D7F03CE905A975F2C62D068347EDD6800DDC0FFFDEBDFA77F7D5C2693AF2CCBE3557A363D393A9E4E583A5F2DE2F4FE6CBA29EEFEF0C3F4AF7FF9DD7F9CBE5D2C1F27BF36DF7D577EC76BA6F9D9F4A128D6AF67B37CFEC096517EB48CE7D92A5FDD1547F3D572162D56B397C7C77F9E9D9CCC182731E5B42693D34F9BB48897ACFA83FF79BE4AE76C5D6CA2E46AB560495EFFCE4BAE2BAA93F7D192E5EB68CECEA6D7574797E95D16E545B699179B8C1D5D444574C44914ECB1984EDE2471C4B9BA66C9DD7412A5E9AA880ACEF3EBCF39BB2EB2557A7FBDE63F44C9CDD39AF1EFEEA22467755F5E779FDB76EBF865D9AD5957B12135DFE4C56AE948F0E4BB5A4E33B5BA97B4A7AD1CB924DF7289174F65AF2B699E4DDFA49B741EAFA613B5ADD7E749567E57C9FA8297C4E951553B66F9515DEBC5A42D7BD1C282A3A7FCF76272BE49CA91394BD9A6C8A2E4C5E4E3E64B12CFFFC69E6E56FF60E959BA49129139CE1E2F937EE03F7DCC566B96154F9FD85DCDF2E5E2EEB6657B261398A914DAFA58E56DFF7EDAC48BE9E43DE726FA92B0160C332D9D0B96DFDEC4C52659A9E438BEB8DA4C2757D1E32F2CBD2F1ECEA67F7A359DBC8B1FD9A2F9A16EE2731A7325E375388A99170BE6B65F1D1F5B356E68AB886ECFA345A96F6D635CE3D80DD75F77C639B13749C1B2681E21D4F495CB01FC9C6FA2CC7500DF475FE3FB0ADA0A45FEE76253ACF2E9E4134BAA0FF28778BD351E47756127E877D96AF9699574F59AA2DB9B28BB67DCF6DCACF0F2EBD5269B3BF0D5F61261AB2E6B68E7225F6A19600C7C8071763AEB6C85D682D4DD74B42075ADF12C48CBB68F05692BF7B420EF974CA535A8F930B77D12C47CFC9A646A5B176C1E2FA3643AF998F1FFD58EC70FD3C9F53C2ABBF0F2B02C92D794426A7E4BAD9F416AD49A32488D5DB065EB9C0BE47E9571CF0AE5AC2DBEED2C6AC71C2C057609F9C4D566D6152F97D13D4BB516BDFA64D9A1128851FE80B2EECA57BD2C69DB7F475BDAD61BCF9A0AACFBD853A17A189F0C101CD4ACDAB4FEFDA1FB657EFE94B391508D98C68E383A562606BBCF30069B520D83ED271883D656A175039D6C425D6B3C8BD0B2ED630FBC1C7C854EE95B29747AF837AE8D6F96B7E7EB3B5DC3274ABBDB76FA1B9F6B963EE80CCF8E7ADC367DFB73943F8CD03E375EEFA39C3B952C2DC2D8C2A10C6B5F3F1137644E4B44D588916BC8E0BEA2A595A57D456088AD595CA5DC90EAD7D7ED375076751129BAA6DC5572EF79BFE671345F315C744D79B4EACC5BC71D2C05A2433EE9E7B6363272735AB7B54674591BB6BD1CD6A6724F77F5ED3251692126F3E5ABEF0FCC5774A4167E53EF6DBA60199B13B6B129C5F45B2D03FA033E70353C372C6177AB94D0EFA614E34D2D03BC810F426E3A363411B3A31441A75829EFE5113703E068719A6AE3999C8E711F9BD3D5EEE915AB8476B6ED575AB85F56F759B4E07018C10BAFB658374B16A46D8B65FF6AB94E98E47FA2C6FC8F81DAFB318AB301BA56AD65D87A1811C68B68C146D9B4799B171CA7BA813BB039D83CE57A79315EFEB4D384AB4E1EE48CEC357B3453A4E3ECD1541B6FF6E818F7993DBADA7D660F6E0A2E2E2EC6D94F517BB03B43F41B555227CF535552D235F552D26E8DEAA8A65DC5F1145564DE4755C5FA7D0F980129FF39D50CD56B3E401BACD1CBB4F8EEA597EA5C721EF87A0192ECA590EFE2654892A1828AC22F837527C9C23E1072980C4B81CA239FB86E766D11230E859E51F83DCAB1FA998E75F0ADE7715298CD3A0DA341D6CE50804EE655AD3E9E91456C8D8FAD75365982A0AE8B55C67E62299FDB0BB6F818157C964FF990613E1A765A42353DDCB2C7DFD1710D0FDBC649F805896DEB8E07B586771F7C3575FBCC0A12891FE334CA9E2470F0FFE2E8382437D72BA4CE14831032008888A622C2843C37368B8CDDBB86FFD4B5C6DCD6ACD9F6DBD5AC2BF7F4742F6BECA9047B84448F79642CCC4D4A87FC7CE992DEAF2C5D380ADAE0B8B5ACA15B3E55D9ADF2A5B8EF837C806CFE605FB9FA6875D7356CD65F40F6AA0292AD6D690097CC4FF7A5BAA33B63BD0C811BDACD6ED8E58255927670C5CCA6E370FDB01ADF4EE8AAEA8C87AA9A651F3079983A85CA7F170B2144B18FE92D83DFDF71AF2D91B9DAAB00F880DB4E822E4BFDB5149E312E86D824D81A627C67402D03D61C7CE0B78F41CF32F524227EA5B2271412FC895F0498717C2C825073F4D9A6877970C167F005BFD4EAB39A63EAF9F3E798232A8B3D0234E4EAA3AF686E859EF458DB886402AF7220E96FEB9D7E4B4B4D449971ADD30E46D734584F806FA8A505FCB097CD3F7F880AD7104D5E65C4F8CC8A61AFE0CCAA664F4DBB62695EEDEC88D40E58B97CBD3B5F7FAC141BE18E2945305850290F913EE3B5FF2CD5FDB6FFFCACF79FC39EBB5AE4EED71BC7C8B120FA019567A07CE5A22B6FF2BC54B1923D79DBBC3D0F967BFB365D4C0C99C65B4D1276D93950B866C46BAE0B9C83B3E9EF810C69AA6D707347B53DA896A99E00AA5C8358566E0045C939973ED7C9382DA0BAC59CDA3A4AF40C28D5483D252E252907A06D492DB9606BBE1CE08CEA251B8085B625C58A9824753A1370A2870F92DC498DB52ED3B31B6E2191D61E46BA4C73577C3A741EE45B51FCD1C9571D77AD5530E15C43D65E7DA034BDD487EA982D7889945127FDA1A410808701140884C952834DC7CC7683DD85F9DBEB0E9DFC222865131DB8131B4C71603B80445A97138828E906E061001081304E6AB0E998CE6EB0BBA05B7B10D1594A438188E260481051D23D0C10A9B95EE4644B257E790C354D150190F50CE90520A25B43E28790C1614C646AFEB4C969D1582062A07506884AC13683F2F8E8E8C4DB0344026A290E75D1B51D93E2F6897DEF3561B983ADA4681E865C4CD1523E8CF5942EF0D962F4E928E8801023C3A7854660D0F1AE414771653BEEC6E8625F1C52631294B161A16972117451EE0181389AAF40F330E4C29796F261780CC88D30E60D1E780957B0BD2378F38CAB4BE2D0793C24D9B04F4AC527833DAE6603DF792796BA02D1B88B16763F1667C316D62D8BFD7765718907606490AD252C1C97DE07D2C6E68A9B4CF541B7CB1E932EA217B80D440BC1B69B34CC384ECA44F8ABE3D69346F0E1F819007020208FC2031D9DD741A18E99B2071919D167E572040217C584ED3806723F2901876163302889518BFA614743297B83090BBF04D60AA51D144E081B8E76010D9CF4401422E6509C0C3821EA014564810499004928ED124468E3B6C3D61F39A83C7B373F1C5C60889F619435F17E00444230A7339AE870413358C3428BE4C4769803FA51A4F403F032C4A25809A22397AD54449DB01CAEC2181D56C24410DE90FE13C1C3C0EE1321DC83F19EF07833C3D909157C063641DC3717F4816B836DDB69D91872E74E2BF17DDCBCDB461356276871CAB226A988A5D1D5AA58E5ED236C20D6F673CEEA70DBBC0E8B56315212BE664513C9107DE94E60BA1846F5040B200D5269F75E0015625706A5226C29023AF40B1818A576B8001DEADE7C949FE6101372435C6E8C51E9E2840099AEC8824E172A02E89057D761744483092869EE7BC16821C72580243C9DB207541B5F4DE18A88DDC6C7A176359061C0F3AA353DA68929BB6A16246BB71B50C213F0344C5184A4A5B3BDA4C4E4274A667406971E7A75DA07542C2C2B45A3E1344094F953212998DE8EAE1A9E3D11BE229E87526703730C77DB19C5728289C51CB8AD90221F6D943B6B2108EC1519280B53383271F2030292956E9096DE448F100B3503B98B053EF90085A20F53C61C3518A8AC7480F63D2CA293778611104B8B08431F6FAB2CB389885BA503D494A9274648837CA3C0591AF06E4F280D7DE0A8D401327454E90035F1EB89ED5C1AE0267BC478E80220654D274220EDB8D792220441BEADE46D3134A8D086F2A13A6EC0848BB9180C11D865985016A6083FA90F9A183FA51BDA2D02ABC0BE9D5951EDDD9B5A01E923D6A88E91316BBD454606AA29942D2E96EC23458DC931C554513D33181E77510D667EB067A0747E1C1E1A44F85D2038A8A71F072282762616E28642D2DBD7C50D618E3A113984FBA544FAB105DD9DFBBB784C0BEAE719835FD0133A3CFC05787CD411816DCC0B6E81A825BABB9CE0DD485044FA700DA93364C086D20FEAB8CE224AC3DA84794B43DA73A0C441861C20BDC0820E3C0582451AE01821EE40F2D624521E9AD3728BF3F21E1AA39542E0EE23F7B79092301C04BB1D05E3F2A1AF1F723B00B693BECFF4ADDEF181CCDDBA134CAB334CD214A037C4589D61EED2BA10B73B90EB2ADDB19CC3C11CEE8BD8CCDDFAE3B8DE3E4E73F9447B5CD4969DCEAEE70F6C19D53F9CCEF82773B62E365172B55AB0246F0AAEA2F53A4EEFF3AE66FDCBE47A1DCDCB71FEC3F574F2B84CD2FC6CFA5014EBD7B3595E91CE8F96F13C5BE5ABBBE268BE5ACEA2C56AF6F2F8F8CFB39393D9724B633697BC49F570AB6D89EB161790525AAED817EC5D9CE5C54554445FA2F28E90F3C5127C060EC7880DE4A63978FE0507B0D94F6EEA94FFAF8FE2AE8E2ED3BBACBC5965332FAFA5392AB93BAADB3E224876727DC7BB5A3E6356F59A0910206BF2BAE5BD955186DCACD22E46CF57C966995A2457D1F48427DE51B258B91B7592AC0F3DE9861B89A054E24651B8E646252914D9D3948E8FD53122376B4A8555E0024E9E014615A3A1C2DE5A29E8958EB75210242D9482ACA91378BB0852054E9EB76840513EF4B364384D50E84697A4E941AFBC0817A527153C47F5F2318123AA57B7331250C148A2162AA6A9AB13BBB0C3A30A5EB3F9A3814737BB10A4F12FDC5AD090F6A3B9576A3222AC691FDB1BD404490B489335434FD314BD725240E949050EF4CA6762D7770AADE6473715E0EEF20302FFFA670F5AB73F47F90341B02E7383FFFB289FC7F553BF2AFEC5B26F6AEA3EFB90078DFE730F4ED266E6A16A6AE79DE65812CC3AD419B06610CBA78997094E13141E2ADC9ED1DAA40D0009885F8AA60580E9AA3A9977512CAAD0E9F8169AA2FCE8BC3AD7F850545F965795422C735C48D5EFC5833554FDBBA32F273E090FBC39B1D08D6EF3F4BB4AB2F9DD71DA2E5F7707D376F9A3636FEBD7DB4147EBDF1DAD5EFD203B3078F5EFCFD1D6F9CC1C23DABA36BC2BA0ADA3685AD83ABAAA4EE65D8C9A2A743A7A8DA6D83E91AEEA53F5A31B1D9C33B9E49B1634281E4D0BB4C75BDE7A4053B5D0045D659DE4C5A33055F8BA38220D469457C8C1BCEA4595B80A4B65D9E2B62C0DE7F8F3E32ACA914FDCDA501F23571B50CB77BFF5F88CBC718880802A6A0A71B4505433895155007FA61A6CA3F45533BF6969FC03A8E67C3DFC39144ED8FE348AAAAF4353132CA042880A22D050C3283953391C87C5E7346FD42D0A2A62A9C70E054AD26A8382A8A9DF9FA86398E0F604115AA60105FA7AB46AE3E017630219BBE58BB0FC1EFC0A77ADA8448910C67D98E377806A6DBCB0F5ECEE85F0DD8D2EF6E03131A30F8AF511114445B57A030725680118A25E4845A568C90F1E8BE4E412B7780FE9E16335E6432A1CDB9C865FFAC28BCE0825DE63A31A5C333421F5D606D5434BFA8D8385294528C3D2676E46DF82B8F5F01E2649DBDED5D490B0F039C5A87CC2FBD405EEEBC1A47BDFD7E4917AB67A80BEA98FF7BF17FBC3DB948590810D083D9BA806B49A764BBECAB500FBF1680686066CF0615D15D54AF1D840F6F70AC60F74DBC1EE947C698D3BF00CF5BFED4EFD560268E47C2119C2D8ED3EEE61C64265329C589331ADC891BE1E088ACE351EB9A36D884C2E85DA32E6C53379BDA1DBD666BBFDAD7FD680E2564D17734608B8B6C4D58075352DE37211F1127794B8E0013BE76EC819DE9173420271338B03ABEE3644CB226764115777945EE6E523DBED03DB8E92E88D24EC060A0F5BD355266D8D3DB0E82B2C0EC1D6A8D764F40559EBCCF881CD8C1090A1AA7ED2CE85F52FEDDF6D866A9D1D2AA5AD561D2D9350AB0EE675A6AA9A2EBAFD643AE1BC7F8D1755AAE8535EB0E51668D7FF4CCE9398CFBEDD0757511ADFB1BCB859FD83A567D397C7C73F4C276F9238CAB779C57522EC6BF5F255ABCCD893EFCACC58B658CED4EAEEF9B525953C5F2448766DA960F5B0E30F25FE8D01C835836BF53EDFE94CA5708AC0ADADBCBD957193C6FFDCB0B8BC2937BE8B59369D949629FA522649D7D669A6A589259F6E497F8DB2F943C4295E458FBFB0F4BE78389BFEE995570316945F1D1F8BA4AB8B764D942597754B7AC155BA8897CC9D4DD959A5A9D97026A93D3550E0A6E1CB74C11ECFA6FF5311793DB9FCBB683E5E4C3E645C935E4F8E27FF6BE89CE8E66A718C7A92F638269C283B1CB79503E2584A190D0E620BCA27EE2096D2486BD4B179BC8C92D27CF2FFE5951D3CE106B39C8278F1CBE7A527468366A927359D5DE80991C969AF29F43DDB56BA22540F6FF501F1802A6345FBFBC3B5FCD608C21F30B0C60F7983890D7AC69B88203F529AA6B51DB523DD646D2A64E9DE5DE69F2B59BC9EDCF0912D7B23B270E285F83ADB336CD7D4ACCFC0D495ECCF00EA34BC6E5A5143D7E63DB402A14769470FDB813F476F3FF7509B1056338F494A1E4896723F6928BF7CF5FD614C0B56D4AC0C71186F054F9EB4070CF97E861562BADA812023675B06F5BDD5A4CBF056BB49C00CCEB69486A953A23FFA506F323283B2DDE6678617469DAA19DC7F6DB23635023E0C1B65BB180B312B5ACC867DCC1B9E2F696FDEC8677DACCC5B573B94796BB22CC37BC32AAFA134EE1B82FB21987C1BD11AC3BACB3F6D502CD60FB9FF06C89A6DB1EDB822E95ADB26E2147BB50D1F5440A4D7629648A40CA0116AF66400E773BC6DB67DDB95B0D6537D9AA3BDB65A3CCE60A3B4BE1A00B7397CB61FA8C643795BFE938AEB710716C7653F98C4D3675623D8D40D647265727C20BEC469943DFDE7327AFCAFE735A91B0F8B2C8D454D6717C602CD9772597413F79BDBADB9EBCA01E772983A687D763BFC3621169DEDED1DD4147ACF7075FA444FC856547637BBF584ADE9D50F87790D1BB82A2EE927967228166CF1312A3828D3B216AB7AD36726B380F59E4E63482291FD80118F4FD88C9301CF8E9292F3F3843177A40352F20EE00CDD7609666922022D67604E99B709DDB1D1EAA501FA47681C0C968B9042FAE052BB0764B7F4896CCEAE129D39E6E434896476E83EC1660ED191F2A066F44D2D2D8BBB57667FC00A12CB1C4E57B1A7B5ED8E56AB9A0121A724A1ED39CAC69EFF5C4377BEED1AEC1A15BFC5085C7D52971DBEECB32360DD8FE69C2833484906FA84D6E0347B39B868677BF088D0DB29467A0411F6C188452ECBF3C108DAD91E3C22F4026044C80E52B08DA7A6740FE729C740D5A37EED6F579BA488D7493CE74DF2E5329015783B5722D3FE2693F93D20C3A1C5B2528A5172BE4AF9DC11C53055F7631673A6D651A230AE7C47CEB8E44DA1A7B396B45A72C1D67C6D55A680CBBD0CD0664B5AD11B932CA44C303D042CB37DB167A2A571147EB5070498C8508ABB8588EEB126C7B87C27989832B37B5AE491B0836542FA59807DC78DAB9A138ED2EE3163E1AD0D8497665AAB2D5E4EC2449943C547645D60E2306D050205FD48160E0A4D96AF35285CE7384D9B0360A009CAC5DF3E12755C0EC9DAAA76F39B3D06D420E0FA61EBE6C7DD4C29E41B4C4EC1F64E28D0BC9BE3DCE8003068A20C8782811AD558D1E97E7C3630D03C29B28F30687261F0456A701438CC2BC7474790D2C1C020E03C34A05F10D016A0C3E705840336062E28B0BC8B6700340877080EB42F014F152A4AE2CFCF667742FB84C73E6E5008703084D676030A3E14871516EE3F522C9E5FF18C22DE3578AC18181646266723D0EA732CAC8CB106F500C6B82E87E5C5633BDEF6C490060B9FE7B6A79373B2A7DB9EDA0BE0C25B947DC0CD18D6C50B339697E90D80172983E416DDBA0DBF452EA7AD20C49A9267B339AE49D4F16B7990DDD06D9C9F2EAC5E756B95D838C1A76D4B5CB6472131824C505716EDAA66984CB7E83BED94866E7A00A054E1BBE4DB8E7DBC4E1D3AA4A0E18A4EFDCB4E90E1E144065AD7506FB4F8343A1818E8A876D562C061947EDF573CE8DFCF718FD3DF21244CCD0E3895E801613982FB3565B88D45FFB1779D21F660D8DB4401FC6D40BFE1B34001485010E909853BC185EB3805F41E746F3339373EC49AF5212A06771FC49482ED1AB5FAE199390FC4C3447BEA3B488909436D85CAD91008B19D2E46C7D8B230BD1E34FE9EE85BF92580F61850B9B51F40A37EEEA1FEBE3D1BEA428ED573B8EDBDFF67D3C5971247DBA8E5F2E926EA427BB58976850E9A684BA826A8E404B50961471134229451CDD01735AB0DB5030C9A694BA846A8207AD097E6F016F6A47D0886EA0771E9A7DA44173E05DAE88AA846C88B22D556BAE81CD04A5744B542DED7A6B6221A64D08E5848B5A4B9A0476D0B9E3C8216E12754BBE6FB8108456A6C2DA54E4DB941A9A8EC340896DAEF41B05297D050C12F88C0E54A37A4941B246ADB6AEDF583D6EADFA956F01472BC4B541352A9A13B76ED418F9D1A2EE113C3B86972AD81D1AA1C4368B1AA9FCD9A8727D412C697C4BF526E30C4B6F887E1E8F414633BA139CC38F058886EDE760ED2342FBF4044A4194D84AF64DB8347FC48BEA4E271542F4FD1112AC8B98A508F4C5E94BB61D1453A8D06E9ACF50B7BF8F1B3D001DD51A82E5D0223B15361D407A476C2C09FD3F21BCB510501121E90FEEB9322F0D598C035BD64F052198F4E82887EA493FAA87F798C64FF753B3464402216E82F54249D4DF76E828875A49BFAA8F620DD54BDE2AA227D3BB1BBEE2A11D998C6EA82B68374D201E83DB4523390DA88E403E82212438BF4D214691B64DE85CB9DAAAAEE5ED33EDD850B286DBF4D8195DAA052A13BB0707F44A2516553546490E96788EED2F17C5A97C3F0EA6868FF0B93202CDC85306CFC2FC373A6019030B420F0C82B7AF9A10BD10AE280A25B30626DEACA1F0FAF0C8B2C425D33630812620695CD16C106D2E75CC819A4E4AA11B7813A771DC4CA20BDD6C7D3F4335F526D690BA7AA48DC21E8D94D692B88EAA72692820A1601E34A1D720FD15539B641036253172D591C10ACE4F93DDD4BC359BF2FF386E37D48407395A2FB94A59C4F631395EE083BA0C68A7B91DB8909BDADCF77D9A19CBCD28B0FDD116D90D918DD0F156B3B4F46E07DF1B6EC74B6DD53AC7FE07F8277C44F679F3669796BDBF6AF0B96C7F71D89534E336573E914B3FDE632BD5B3527AA0A47CD27CA8D4D57AC88165111BDC98AF82E9A17BC78CEF23C4EEFA7935FA36453AAC0F20B5B5CA61F36C57A53F02EB3E597E44914467928AB6BFF7406783EFDB02EFFCA437481B3199717DD7D487FDCC4C9A2E5FB1D72231441A23CEDAD2FCA2EC7B2282FCCBE7F6A29BD075B0A14A15A7CED21F50D5BAE134E2CFF905E475F990F6F9F73F60B3732F3A78FF573F03411F340C8623FBD88A3FB2C5AE6358DAE3EFF936378B17CFCCBFF03EFDB7A7F2C420100 , N'6.1.3-40302')

