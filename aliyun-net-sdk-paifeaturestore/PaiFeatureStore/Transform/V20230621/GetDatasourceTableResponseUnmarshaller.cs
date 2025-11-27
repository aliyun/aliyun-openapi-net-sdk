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
    public class GetDatasourceTableResponseUnmarshaller
    {
        public static GetDatasourceTableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDatasourceTableResponse getDatasourceTableResponse = new GetDatasourceTableResponse();

			getDatasourceTableResponse.HttpResponse = _ctx.HttpResponse;
			getDatasourceTableResponse.RequestId = _ctx.StringValue("GetDatasourceTable.RequestId");
			getDatasourceTableResponse.TableName = _ctx.StringValue("GetDatasourceTable.TableName");

			List<GetDatasourceTableResponse.GetDatasourceTable_FieldsItem> getDatasourceTableResponse_fields = new List<GetDatasourceTableResponse.GetDatasourceTable_FieldsItem>();
			for (int i = 0; i < _ctx.Length("GetDatasourceTable.Fields.Length"); i++) {
				GetDatasourceTableResponse.GetDatasourceTable_FieldsItem fieldsItem = new GetDatasourceTableResponse.GetDatasourceTable_FieldsItem();
				fieldsItem.Name = _ctx.StringValue("GetDatasourceTable.Fields["+ i +"].Name");
				fieldsItem.Type = _ctx.StringValue("GetDatasourceTable.Fields["+ i +"].Type");

				List<string> fieldsItem_attributes = new List<string>();
				for (int j = 0; j < _ctx.Length("GetDatasourceTable.Fields["+ i +"].Attributes.Length"); j++) {
					fieldsItem_attributes.Add(_ctx.StringValue("GetDatasourceTable.Fields["+ i +"].Attributes["+ j +"]"));
				}
				fieldsItem.Attributes = fieldsItem_attributes;

				getDatasourceTableResponse_fields.Add(fieldsItem);
			}
			getDatasourceTableResponse.Fields = getDatasourceTableResponse_fields;
        
			return getDatasourceTableResponse;
        }
    }
}
