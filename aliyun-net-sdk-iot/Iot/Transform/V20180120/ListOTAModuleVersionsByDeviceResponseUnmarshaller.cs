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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListOTAModuleVersionsByDeviceResponseUnmarshaller
    {
        public static ListOTAModuleVersionsByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTAModuleVersionsByDeviceResponse listOTAModuleVersionsByDeviceResponse = new ListOTAModuleVersionsByDeviceResponse();

			listOTAModuleVersionsByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listOTAModuleVersionsByDeviceResponse.RequestId = _ctx.StringValue("ListOTAModuleVersionsByDevice.RequestId");
			listOTAModuleVersionsByDeviceResponse.Success = _ctx.BooleanValue("ListOTAModuleVersionsByDevice.Success");
			listOTAModuleVersionsByDeviceResponse.Code = _ctx.StringValue("ListOTAModuleVersionsByDevice.Code");
			listOTAModuleVersionsByDeviceResponse.ErrorMessage = _ctx.StringValue("ListOTAModuleVersionsByDevice.ErrorMessage");
			listOTAModuleVersionsByDeviceResponse.Total = _ctx.IntegerValue("ListOTAModuleVersionsByDevice.Total");
			listOTAModuleVersionsByDeviceResponse.PageSize = _ctx.IntegerValue("ListOTAModuleVersionsByDevice.PageSize");
			listOTAModuleVersionsByDeviceResponse.PageCount = _ctx.IntegerValue("ListOTAModuleVersionsByDevice.PageCount");
			listOTAModuleVersionsByDeviceResponse.CurrentPage = _ctx.IntegerValue("ListOTAModuleVersionsByDevice.CurrentPage");

			List<ListOTAModuleVersionsByDeviceResponse.ListOTAModuleVersionsByDevice_SimpleOTAModuleInfo> listOTAModuleVersionsByDeviceResponse_data = new List<ListOTAModuleVersionsByDeviceResponse.ListOTAModuleVersionsByDevice_SimpleOTAModuleInfo>();
			for (int i = 0; i < _ctx.Length("ListOTAModuleVersionsByDevice.Data.Length"); i++) {
				ListOTAModuleVersionsByDeviceResponse.ListOTAModuleVersionsByDevice_SimpleOTAModuleInfo simpleOTAModuleInfo = new ListOTAModuleVersionsByDeviceResponse.ListOTAModuleVersionsByDevice_SimpleOTAModuleInfo();
				simpleOTAModuleInfo.ProductKey = _ctx.StringValue("ListOTAModuleVersionsByDevice.Data["+ i +"].ProductKey");
				simpleOTAModuleInfo.DeviceName = _ctx.StringValue("ListOTAModuleVersionsByDevice.Data["+ i +"].DeviceName");
				simpleOTAModuleInfo.IotId = _ctx.StringValue("ListOTAModuleVersionsByDevice.Data["+ i +"].IotId");
				simpleOTAModuleInfo.ModuleVersion = _ctx.StringValue("ListOTAModuleVersionsByDevice.Data["+ i +"].ModuleVersion");
				simpleOTAModuleInfo.ModuleName = _ctx.StringValue("ListOTAModuleVersionsByDevice.Data["+ i +"].ModuleName");

				listOTAModuleVersionsByDeviceResponse_data.Add(simpleOTAModuleInfo);
			}
			listOTAModuleVersionsByDeviceResponse.Data = listOTAModuleVersionsByDeviceResponse_data;
        
			return listOTAModuleVersionsByDeviceResponse;
        }
    }
}
