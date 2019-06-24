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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAuditSecurityIpResponseUnmarshaller
    {
        public static ListAuditSecurityIpResponse Unmarshall(UnmarshallerContext context)
        {
			ListAuditSecurityIpResponse listAuditSecurityIpResponse = new ListAuditSecurityIpResponse();

			listAuditSecurityIpResponse.HttpResponse = context.HttpResponse;
			listAuditSecurityIpResponse.RequestId = context.StringValue("ListAuditSecurityIp.RequestId");

			List<ListAuditSecurityIpResponse.ListAuditSecurityIp_SecurityIp> listAuditSecurityIpResponse_securityIpList = new List<ListAuditSecurityIpResponse.ListAuditSecurityIp_SecurityIp>();
			for (int i = 0; i < context.Length("ListAuditSecurityIp.SecurityIpList.Length"); i++) {
				ListAuditSecurityIpResponse.ListAuditSecurityIp_SecurityIp securityIp = new ListAuditSecurityIpResponse.ListAuditSecurityIp_SecurityIp();
				securityIp.SecurityGroupName = context.StringValue("ListAuditSecurityIp.SecurityIpList["+ i +"].SecurityGroupName");
				securityIp.Ips = context.StringValue("ListAuditSecurityIp.SecurityIpList["+ i +"].Ips");
				securityIp.CreationTime = context.StringValue("ListAuditSecurityIp.SecurityIpList["+ i +"].CreationTime");
				securityIp.ModificationTime = context.StringValue("ListAuditSecurityIp.SecurityIpList["+ i +"].ModificationTime");

				listAuditSecurityIpResponse_securityIpList.Add(securityIp);
			}
			listAuditSecurityIpResponse.SecurityIpList = listAuditSecurityIpResponse_securityIpList;
        
			return listAuditSecurityIpResponse;
        }
    }
}
