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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class GetLabelTableResponseUnmarshaller
    {
        public static GetLabelTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLabelTableResponse getLabelTableResponse = new GetLabelTableResponse();

			getLabelTableResponse.HttpResponse = _ctx.HttpResponse;
			getLabelTableResponse.RequestId = _ctx.StringValue("GetLabelTable.RequestId");
			getLabelTableResponse.ProjectId = _ctx.StringValue("GetLabelTable.ProjectId");
			getLabelTableResponse.ProjectName = _ctx.StringValue("GetLabelTable.ProjectName");
			getLabelTableResponse.DatasourceId = _ctx.StringValue("GetLabelTable.DatasourceId");
			getLabelTableResponse.Name = _ctx.StringValue("GetLabelTable.Name");
			getLabelTableResponse.DatasourceName = _ctx.StringValue("GetLabelTable.DatasourceName");
			getLabelTableResponse.Owner = _ctx.StringValue("GetLabelTable.Owner");
			getLabelTableResponse.GmtCreateTime = _ctx.StringValue("GetLabelTable.GmtCreateTime");
			getLabelTableResponse.GmtModifiedTime = _ctx.StringValue("GetLabelTable.GmtModifiedTime");

			List<string> getLabelTableResponse_relatedModelFeatures = new List<string>();
			for (int i = 0; i < _ctx.Length("GetLabelTable.RelatedModelFeatures.Length"); i++) {
				getLabelTableResponse_relatedModelFeatures.Add(_ctx.StringValue("GetLabelTable.RelatedModelFeatures["+ i +"]"));
			}
			getLabelTableResponse.RelatedModelFeatures = getLabelTableResponse_relatedModelFeatures;

			List<GetLabelTableResponse.GetLabelTable_Field> getLabelTableResponse_fields = new List<GetLabelTableResponse.GetLabelTable_Field>();
			for (int i = 0; i < _ctx.Length("GetLabelTable.Fields.Length"); i++) {
				GetLabelTableResponse.GetLabelTable_Field field = new GetLabelTableResponse.GetLabelTable_Field();
				field.Name = _ctx.StringValue("GetLabelTable.Fields["+ i +"].Name");
				field.Type = _ctx.StringValue("GetLabelTable.Fields["+ i +"].Type");

				List<string> field_attributes = new List<string>();
				for (int j = 0; j < _ctx.Length("GetLabelTable.Fields["+ i +"].Attributes.Length"); j++) {
					field_attributes.Add(_ctx.StringValue("GetLabelTable.Fields["+ i +"].Attributes["+ j +"]"));
				}
				field.Attributes = field_attributes;

				getLabelTableResponse_fields.Add(field);
			}
			getLabelTableResponse.Fields = getLabelTableResponse_fields;
        
			return getLabelTableResponse;
        }
    }
}
