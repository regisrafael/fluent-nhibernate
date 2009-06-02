﻿using System.Xml;
using FluentNHibernate.MappingModel.ClassBased;

namespace FluentNHibernate.MappingModel.Output
{
    public class XmlComponentWriter : BaseXmlComponentWriter, IXmlWriter<ComponentMapping>
    {
        public XmlComponentWriter(IXmlWriterServiceLocator serviceLocator)
            : base(serviceLocator)
        {}

        public XmlDocument Write(ComponentMapping mappingModel)
        {
            document = null;
            mappingModel.AcceptVisitor(this);
            return document;
        }

        public override void ProcessComponent(ComponentMapping componentMapping)
        {
            document = WriteComponent("component", componentMapping);
        }
    }
}
