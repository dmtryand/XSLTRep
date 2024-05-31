<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns="http://kak.ru/"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="book_store">
		<данные_о_книгах>
			<xsl:for-each select ="//book">
				<книга>
					<!--<xsl:attribute name="id">
						<xsl:value-of select="autor"/>
					</xsl:attribute>-->
					<название>
						<xsl:value-of select="name"/>
					</название>
					<!--<издание>
						<xsl:value-of select="public"/>
						<xsl:attribute name="год">
							<xsl:value-of select ="name/@year"/>
						</xsl:attribute>
						<авторы>
							<xsl:value-of select="autor"/>
						</авторы>
						<издательство>
							<xsl:value-of select="autor"/>
						</издательство>
					</издание>-->			
					<!--<отдел>
						<xsl:value-of select="department"/>
					</отдел>-->
				</книга>
			</xsl:for-each>
		</данные_о_книгах>
    </xsl:template>
</xsl:stylesheet>
