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
    public class DescribeSmartAccessGatewayHaResponseUnmarshaller
    {
        public static DescribeSmartAccessGatewayHaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSmartAccessGatewayHaResponse describeSmartAccessGatewayHaResponse = new DescribeSmartAccessGatewayHaResponse();

			describeSmartAccessGatewayHaResponse.HttpResponse = context.HttpResponse;
			describeSmartAccessGatewayHaResponse.RequestId = context.StringValue("DescribeSmartAccessGatewayHa.RequestId");
			describeSmartAccessGatewayHaResponse.DeviceLevelBackupState = context.StringValue("DescribeSmartAccessGatewayHa.DeviceLevelBackupState");
			describeSmartAccessGatewayHaResponse.DeviceLevelBackupType = context.StringValue("DescribeSmartAccessGatewayHa.DeviceLevelBackupType");
			describeSmartAccessGatewayHaResponse.MainDeviceId = context.StringValue("DescribeSmartAccessGatewayHa.MainDeviceId");
			describeSmartAccessGatewayHaResponse.BackupDeviceId = context.StringValue("DescribeSmartAccessGatewayHa.BackupDeviceId");
			describeSmartAccessGatewayHaResponse.SmartAGId = context.StringValue("DescribeSmartAccessGatewayHa.SmartAGId");

			List<DescribeSmartAccessGatewayHaResponse.DescribeSmartAccessGatewayHa_LinkBackupInfoListItem> describeSmartAccessGatewayHaResponse_linkBackupInfoList = new List<DescribeSmartAccessGatewayHaResponse.DescribeSmartAccessGatewayHa_LinkBackupInfoListItem>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayHa.LinkBackupInfoList.Length"); i++) {
				DescribeSmartAccessGatewayHaResponse.DescribeSmartAccessGatewayHa_LinkBackupInfoListItem linkBackupInfoListItem = new DescribeSmartAccessGatewayHaResponse.DescribeSmartAccessGatewayHa_LinkBackupInfoListItem();
				linkBackupInfoListItem.LinkLevelBackupState = context.StringValue("DescribeSmartAccessGatewayHa.LinkBackupInfoList["+ i +"].LinkLevelBackupState");
				linkBackupInfoListItem.LinkLevelBackupType = context.StringValue("DescribeSmartAccessGatewayHa.LinkBackupInfoList["+ i +"].LinkLevelBackupType");
				linkBackupInfoListItem.MainLinkId = context.StringValue("DescribeSmartAccessGatewayHa.LinkBackupInfoList["+ i +"].MainLinkId");
				linkBackupInfoListItem.MainLinkState = context.StringValue("DescribeSmartAccessGatewayHa.LinkBackupInfoList["+ i +"].MainLinkState");
				linkBackupInfoListItem.BackupLinkId = context.StringValue("DescribeSmartAccessGatewayHa.LinkBackupInfoList["+ i +"].BackupLinkId");
				linkBackupInfoListItem.BackupLinkState = context.StringValue("DescribeSmartAccessGatewayHa.LinkBackupInfoList["+ i +"].BackupLinkState");

				describeSmartAccessGatewayHaResponse_linkBackupInfoList.Add(linkBackupInfoListItem);
			}
			describeSmartAccessGatewayHaResponse.LinkBackupInfoList = describeSmartAccessGatewayHaResponse_linkBackupInfoList;
        
			return describeSmartAccessGatewayHaResponse;
        }
    }
}
