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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSAGDeviceInfoResponseUnmarshaller
    {
        public static DescribeSAGDeviceInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSAGDeviceInfoResponse describeSAGDeviceInfoResponse = new DescribeSAGDeviceInfoResponse();

			describeSAGDeviceInfoResponse.HttpResponse = context.HttpResponse;
			describeSAGDeviceInfoResponse.RequestId = context.StringValue("DescribeSAGDeviceInfo.RequestId");
			describeSAGDeviceInfoResponse.Version = context.StringValue("DescribeSAGDeviceInfo.Version");
			describeSAGDeviceInfoResponse.VpnState = context.StringValue("DescribeSAGDeviceInfo.VpnState");
			describeSAGDeviceInfoResponse.SmartAGType = context.StringValue("DescribeSAGDeviceInfo.SmartAGType");
			describeSAGDeviceInfoResponse.ControllerState = context.StringValue("DescribeSAGDeviceInfo.ControllerState");
			describeSAGDeviceInfoResponse.StartupTime = context.StringValue("DescribeSAGDeviceInfo.StartupTime");
			describeSAGDeviceInfoResponse.LastConnectedControllerTime = context.StringValue("DescribeSAGDeviceInfo.LastConnectedControllerTime");
			describeSAGDeviceInfoResponse.ServiceIP = context.StringValue("DescribeSAGDeviceInfo.ServiceIP");
			describeSAGDeviceInfoResponse.SynStatus = context.StringValue("DescribeSAGDeviceInfo.SynStatus");
        
			return describeSAGDeviceInfoResponse;
        }
    }
}
