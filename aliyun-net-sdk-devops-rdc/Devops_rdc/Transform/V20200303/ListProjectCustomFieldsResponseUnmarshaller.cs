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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListProjectCustomFieldsResponseUnmarshaller
    {
        public static ListProjectCustomFieldsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProjectCustomFieldsResponse listProjectCustomFieldsResponse = new ListProjectCustomFieldsResponse();

			listProjectCustomFieldsResponse.HttpResponse = _ctx.HttpResponse;
			listProjectCustomFieldsResponse.Successful = _ctx.BooleanValue("ListProjectCustomFields.Successful");
			listProjectCustomFieldsResponse.ErrorCode = _ctx.StringValue("ListProjectCustomFields.ErrorCode");
			listProjectCustomFieldsResponse.ErrorMsg = _ctx.StringValue("ListProjectCustomFields.ErrorMsg");
			listProjectCustomFieldsResponse.RequestId = _ctx.StringValue("ListProjectCustomFields.RequestId");

			List<ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField> listProjectCustomFieldsResponse_object = new List<ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField>();
			for (int i = 0; i < _ctx.Length("ListProjectCustomFields.Object.Length"); i++) {
				ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField customField = new ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField();
				customField.CustomFieldId = _ctx.StringValue("ListProjectCustomFields.Object["+ i +"].CustomFieldId");
				customField.Type = _ctx.StringValue("ListProjectCustomFields.Object["+ i +"].Type");
				customField.Subtype = _ctx.StringValue("ListProjectCustomFields.Object["+ i +"].Subtype");
				customField.Name = _ctx.StringValue("ListProjectCustomFields.Object["+ i +"].Name");

				List<ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField.ListProjectCustomFields__Value> customField_values = new List<ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField.ListProjectCustomFields__Value>();
				for (int j = 0; j < _ctx.Length("ListProjectCustomFields.Object["+ i +"].Values.Length"); j++) {
					ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField.ListProjectCustomFields__Value _value = new ListProjectCustomFieldsResponse.ListProjectCustomFields_CustomField.ListProjectCustomFields__Value();
					_value.Id = _ctx.StringValue("ListProjectCustomFields.Object["+ i +"].Values["+ j +"].Id");
					_value._Value = _ctx.StringValue("ListProjectCustomFields.Object["+ i +"].Values["+ j +"].Value");

					customField_values.Add(_value);
				}
				customField.Values = customField_values;

				listProjectCustomFieldsResponse_object.Add(customField);
			}
			listProjectCustomFieldsResponse._Object = listProjectCustomFieldsResponse_object;
        
			return listProjectCustomFieldsResponse;
        }
    }
}
