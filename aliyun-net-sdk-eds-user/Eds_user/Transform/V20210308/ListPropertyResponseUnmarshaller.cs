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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class ListPropertyResponseUnmarshaller
    {
        public static ListPropertyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPropertyResponse listPropertyResponse = new ListPropertyResponse();

			listPropertyResponse.HttpResponse = _ctx.HttpResponse;
			listPropertyResponse.RequestId = _ctx.StringValue("ListProperty.RequestId");
			listPropertyResponse.NextToken = _ctx.StringValue("ListProperty.NextToken");

			List<ListPropertyResponse.ListProperty_Data> listPropertyResponse_properties = new List<ListPropertyResponse.ListProperty_Data>();
			for (int i = 0; i < _ctx.Length("ListProperty.Properties.Length"); i++) {
				ListPropertyResponse.ListProperty_Data data = new ListPropertyResponse.ListProperty_Data();
				data.PropertyId = _ctx.LongValue("ListProperty.Properties["+ i +"].PropertyId");
				data.PropertyKey = _ctx.StringValue("ListProperty.Properties["+ i +"].PropertyKey");

				List<ListPropertyResponse.ListProperty_Data.ListProperty_PropertyValuesItem> data_propertyValues = new List<ListPropertyResponse.ListProperty_Data.ListProperty_PropertyValuesItem>();
				for (int j = 0; j < _ctx.Length("ListProperty.Properties["+ i +"].PropertyValues.Length"); j++) {
					ListPropertyResponse.ListProperty_Data.ListProperty_PropertyValuesItem propertyValuesItem = new ListPropertyResponse.ListProperty_Data.ListProperty_PropertyValuesItem();
					propertyValuesItem.PropertyValueId = _ctx.LongValue("ListProperty.Properties["+ i +"].PropertyValues["+ j +"].PropertyValueId");
					propertyValuesItem.PropertyValue = _ctx.StringValue("ListProperty.Properties["+ i +"].PropertyValues["+ j +"].PropertyValue");

					data_propertyValues.Add(propertyValuesItem);
				}
				data.PropertyValues = data_propertyValues;

				listPropertyResponse_properties.Add(data);
			}
			listPropertyResponse.Properties = listPropertyResponse_properties;
        
			return listPropertyResponse;
        }
    }
}
