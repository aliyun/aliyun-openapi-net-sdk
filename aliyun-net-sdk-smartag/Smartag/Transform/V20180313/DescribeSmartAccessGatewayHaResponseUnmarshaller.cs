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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Smartag.Model.V20180313;
using System;
using System.Collections.Generic;

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
			describeSmartAccessGatewayHaResponse.LinkLevelBackupState = context.StringValue("DescribeSmartAccessGatewayHa.LinkLevelBackupState");
			describeSmartAccessGatewayHaResponse.LinkLevelBackupType = context.StringValue("DescribeSmartAccessGatewayHa.LinkLevelBackupType");
			describeSmartAccessGatewayHaResponse.MainLinkId = context.StringValue("DescribeSmartAccessGatewayHa.MainLinkId");
			describeSmartAccessGatewayHaResponse.BackupLinkId = context.StringValue("DescribeSmartAccessGatewayHa.BackupLinkId");
			describeSmartAccessGatewayHaResponse.SmartAGId = context.StringValue("DescribeSmartAccessGatewayHa.SmartAGId");
			describeSmartAccessGatewayHaResponse.MainLinkState = context.StringValue("DescribeSmartAccessGatewayHa.MainLinkState");
			describeSmartAccessGatewayHaResponse.BackupLinkState = context.StringValue("DescribeSmartAccessGatewayHa.BackupLinkState");
        
			return describeSmartAccessGatewayHaResponse;
        }
    }
}