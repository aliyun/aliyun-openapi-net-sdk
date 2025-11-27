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
    public class ListPropertyValueResponseUnmarshaller
    {
        public static ListPropertyValueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPropertyValueResponse listPropertyValueResponse = new ListPropertyValueResponse();

			listPropertyValueResponse.HttpResponse = _ctx.HttpResponse;
			listPropertyValueResponse.RequestId = _ctx.StringValue("ListPropertyValue.RequestId");

			List<ListPropertyValueResponse.ListPropertyValue_Data> listPropertyValueResponse_propertyValueInfos = new List<ListPropertyValueResponse.ListPropertyValue_Data>();
			for (int i = 0; i < _ctx.Length("ListPropertyValue.PropertyValueInfos.Length"); i++) {
				ListPropertyValueResponse.ListPropertyValue_Data data = new ListPropertyValueResponse.ListPropertyValue_Data();
				data.PropertyValueId = _ctx.LongValue("ListPropertyValue.PropertyValueInfos["+ i +"].PropertyValueId");
				data.PropertyValue = _ctx.StringValue("ListPropertyValue.PropertyValueInfos["+ i +"].PropertyValue");

				listPropertyValueResponse_propertyValueInfos.Add(data);
			}
			listPropertyValueResponse.PropertyValueInfos = listPropertyValueResponse_propertyValueInfos;
        
			return listPropertyValueResponse;
        }
    }
}
