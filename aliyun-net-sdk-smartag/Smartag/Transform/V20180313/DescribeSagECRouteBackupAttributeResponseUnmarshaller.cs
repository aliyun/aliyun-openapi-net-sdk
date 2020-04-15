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
    public class DescribeSagECRouteBackupAttributeResponseUnmarshaller
    {
        public static DescribeSagECRouteBackupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagECRouteBackupAttributeResponse describeSagECRouteBackupAttributeResponse = new DescribeSagECRouteBackupAttributeResponse();

			describeSagECRouteBackupAttributeResponse.HttpResponse = context.HttpResponse;
			describeSagECRouteBackupAttributeResponse.RequestId = context.StringValue("DescribeSagECRouteBackupAttribute.RequestId");
			describeSagECRouteBackupAttributeResponse.SagId = context.StringValue("DescribeSagECRouteBackupAttribute.SagId");
			describeSagECRouteBackupAttributeResponse.HcIp = context.StringValue("DescribeSagECRouteBackupAttribute.HcIp");
			describeSagECRouteBackupAttributeResponse.ExpressConnectionInterface = context.StringValue("DescribeSagECRouteBackupAttribute.ExpressConnectionInterface");
			describeSagECRouteBackupAttributeResponse.ExpressConnectionNexthop = context.StringValue("DescribeSagECRouteBackupAttribute.ExpressConnectionNexthop");
			describeSagECRouteBackupAttributeResponse.RouteBackup = context.BooleanValue("DescribeSagECRouteBackupAttribute.RouteBackup");
			describeSagECRouteBackupAttributeResponse.Status = context.StringValue("DescribeSagECRouteBackupAttribute.Status");

			List<DescribeSagECRouteBackupAttributeResponse.DescribeSagECRouteBackupAttribute_Cidr> describeSagECRouteBackupAttributeResponse_cidrs = new List<DescribeSagECRouteBackupAttributeResponse.DescribeSagECRouteBackupAttribute_Cidr>();
			for (int i = 0; i < context.Length("DescribeSagECRouteBackupAttribute.Cidrs.Length"); i++) {
				DescribeSagECRouteBackupAttributeResponse.DescribeSagECRouteBackupAttribute_Cidr cidr = new DescribeSagECRouteBackupAttributeResponse.DescribeSagECRouteBackupAttribute_Cidr();
				cidr.Cidr = context.StringValue("DescribeSagECRouteBackupAttribute.Cidrs["+ i +"].Cidr");
				cidr.EnableBackup = context.BooleanValue("DescribeSagECRouteBackupAttribute.Cidrs["+ i +"].EnableBackup");

				describeSagECRouteBackupAttributeResponse_cidrs.Add(cidr);
			}
			describeSagECRouteBackupAttributeResponse.Cidrs = describeSagECRouteBackupAttributeResponse_cidrs;
        
			return describeSagECRouteBackupAttributeResponse;
        }
    }
}
