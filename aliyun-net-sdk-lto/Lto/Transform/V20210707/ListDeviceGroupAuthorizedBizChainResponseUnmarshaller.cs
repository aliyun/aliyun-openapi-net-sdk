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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListDeviceGroupAuthorizedBizChainResponseUnmarshaller
    {
        public static ListDeviceGroupAuthorizedBizChainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceGroupAuthorizedBizChainResponse listDeviceGroupAuthorizedBizChainResponse = new ListDeviceGroupAuthorizedBizChainResponse();

			listDeviceGroupAuthorizedBizChainResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceGroupAuthorizedBizChainResponse.Code = _ctx.StringValue("ListDeviceGroupAuthorizedBizChain.Code");
			listDeviceGroupAuthorizedBizChainResponse.HttpStatusCode = _ctx.IntegerValue("ListDeviceGroupAuthorizedBizChain.HttpStatusCode");
			listDeviceGroupAuthorizedBizChainResponse.Message = _ctx.StringValue("ListDeviceGroupAuthorizedBizChain.Message");
			listDeviceGroupAuthorizedBizChainResponse.RequestId = _ctx.StringValue("ListDeviceGroupAuthorizedBizChain.RequestId");
			listDeviceGroupAuthorizedBizChainResponse.Success = _ctx.BooleanValue("ListDeviceGroupAuthorizedBizChain.Success");

			List<ListDeviceGroupAuthorizedBizChainResponse.ListDeviceGroupAuthorizedBizChain_DeviceGroupAuthorizedInfo> listDeviceGroupAuthorizedBizChainResponse_data = new List<ListDeviceGroupAuthorizedBizChainResponse.ListDeviceGroupAuthorizedBizChain_DeviceGroupAuthorizedInfo>();
			for (int i = 0; i < _ctx.Length("ListDeviceGroupAuthorizedBizChain.Data.Length"); i++) {
				ListDeviceGroupAuthorizedBizChainResponse.ListDeviceGroupAuthorizedBizChain_DeviceGroupAuthorizedInfo deviceGroupAuthorizedInfo = new ListDeviceGroupAuthorizedBizChainResponse.ListDeviceGroupAuthorizedBizChain_DeviceGroupAuthorizedInfo();
				deviceGroupAuthorizedInfo.BizChainName = _ctx.StringValue("ListDeviceGroupAuthorizedBizChain.Data["+ i +"].BizChainName");
				deviceGroupAuthorizedInfo.BizChainId = _ctx.StringValue("ListDeviceGroupAuthorizedBizChain.Data["+ i +"].BizChainId");
				deviceGroupAuthorizedInfo.Authorized = _ctx.BooleanValue("ListDeviceGroupAuthorizedBizChain.Data["+ i +"].Authorized");
				deviceGroupAuthorizedInfo.BlockChainType = _ctx.StringValue("ListDeviceGroupAuthorizedBizChain.Data["+ i +"].BlockChainType");

				listDeviceGroupAuthorizedBizChainResponse_data.Add(deviceGroupAuthorizedInfo);
			}
			listDeviceGroupAuthorizedBizChainResponse.Data = listDeviceGroupAuthorizedBizChainResponse_data;
        
			return listDeviceGroupAuthorizedBizChainResponse;
        }
    }
}
