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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListDevicePersonResponseUnmarshaller
    {
        public static ListDevicePersonResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevicePersonResponse listDevicePersonResponse = new ListDevicePersonResponse();

			listDevicePersonResponse.HttpResponse = _ctx.HttpResponse;
			listDevicePersonResponse.Code = _ctx.StringValue("ListDevicePerson.Code");
			listDevicePersonResponse.Message = _ctx.StringValue("ListDevicePerson.Message");
			listDevicePersonResponse.RequestId = _ctx.StringValue("ListDevicePerson.RequestId");
			listDevicePersonResponse.PageNumber = _ctx.LongValue("ListDevicePerson.PageNumber");
			listDevicePersonResponse.PageSize = _ctx.LongValue("ListDevicePerson.PageSize");
			listDevicePersonResponse.TotalCount = _ctx.LongValue("ListDevicePerson.TotalCount");

			List<ListDevicePersonResponse.ListDevicePerson_Datas> listDevicePersonResponse_data = new List<ListDevicePersonResponse.ListDevicePerson_Datas>();
			for (int i = 0; i < _ctx.Length("ListDevicePerson.Data.Length"); i++) {
				ListDevicePersonResponse.ListDevicePerson_Datas datas = new ListDevicePersonResponse.ListDevicePerson_Datas();
				datas.PersonId = _ctx.StringValue("ListDevicePerson.Data["+ i +"].PersonId");
				datas.DataSourceId = _ctx.StringValue("ListDevicePerson.Data["+ i +"].DataSourceId");
				datas.Gender = _ctx.StringValue("ListDevicePerson.Data["+ i +"].Gender");
				datas.FreqNum = _ctx.StringValue("ListDevicePerson.Data["+ i +"].FreqNum");
				datas.TargetPicUrlPath = _ctx.StringValue("ListDevicePerson.Data["+ i +"].TargetPicUrlPath");

				listDevicePersonResponse_data.Add(datas);
			}
			listDevicePersonResponse.Data = listDevicePersonResponse_data;
        
			return listDevicePersonResponse;
        }
    }
}
