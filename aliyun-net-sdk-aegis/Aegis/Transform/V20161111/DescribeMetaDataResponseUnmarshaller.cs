/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeMetaDataResponseUnmarshaller
    {
        public static DescribeMetaDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMetaDataResponse describeMetaDataResponse = new DescribeMetaDataResponse();

			describeMetaDataResponse.HttpResponse = context.HttpResponse;
			describeMetaDataResponse.RequestId = context.StringValue("DescribeMetaData.RequestId");

			DescribeMetaDataResponse.DescribeMetaData_MetaData metaData = new DescribeMetaDataResponse.DescribeMetaData_MetaData();
			metaData.LogStoreName = context.StringValue("DescribeMetaData.MetaData.LogStoreName");
			metaData.ProjectName = context.StringValue("DescribeMetaData.MetaData.ProjectName");
			metaData.Status = context.IntegerValue("DescribeMetaData.MetaData.Status");

			List<DescribeMetaDataResponse.DescribeMetaData_MetaData.DescribeMetaData_DatasourceField> metaData_datasourceFieldList = new List<DescribeMetaDataResponse.DescribeMetaData_MetaData.DescribeMetaData_DatasourceField>();
			for (int i = 0; i < context.Length("DescribeMetaData.MetaData.DatasourceFieldList.Length"); i++) {
				DescribeMetaDataResponse.DescribeMetaData_MetaData.DescribeMetaData_DatasourceField datasourceField = new DescribeMetaDataResponse.DescribeMetaData_MetaData.DescribeMetaData_DatasourceField();
				datasourceField.FieldName = context.StringValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].FieldName");
				datasourceField.ValueType = context.StringValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].ValueType");
				datasourceField.FieldDescription = context.StringValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].FieldDescription");
				datasourceField.FieldAliasName = context.StringValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].FieldAliasName");
				datasourceField.FieldType = context.StringValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].FieldType");
				datasourceField.FieldValue = context.StringValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].FieldValue");
				datasourceField.IsIdentification = context.IntegerValue("DescribeMetaData.MetaData.DatasourceFieldList["+ i +"].IsIdentification");

				metaData_datasourceFieldList.Add(datasourceField);
			}
			metaData.DatasourceFieldList = metaData_datasourceFieldList;
			describeMetaDataResponse.MetaData = metaData;
        
			return describeMetaDataResponse;
        }
    }
}
