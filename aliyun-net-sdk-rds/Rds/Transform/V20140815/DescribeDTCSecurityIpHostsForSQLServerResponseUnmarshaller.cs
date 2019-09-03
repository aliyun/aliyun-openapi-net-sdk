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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDTCSecurityIpHostsForSQLServerResponseUnmarshaller
    {
        public static DescribeDTCSecurityIpHostsForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDTCSecurityIpHostsForSQLServerResponse describeDTCSecurityIpHostsForSQLServerResponse = new DescribeDTCSecurityIpHostsForSQLServerResponse();

			describeDTCSecurityIpHostsForSQLServerResponse.HttpResponse = context.HttpResponse;
			describeDTCSecurityIpHostsForSQLServerResponse.RequestId = context.StringValue("DescribeDTCSecurityIpHostsForSQLServer.RequestId");
			describeDTCSecurityIpHostsForSQLServerResponse.DBInstanceId = context.StringValue("DescribeDTCSecurityIpHostsForSQLServer.DBInstanceId");
			describeDTCSecurityIpHostsForSQLServerResponse.IpHostPairNum = context.StringValue("DescribeDTCSecurityIpHostsForSQLServer.IpHostPairNum");

			List<DescribeDTCSecurityIpHostsForSQLServerResponse.DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups> describeDTCSecurityIpHostsForSQLServerResponse_items = new List<DescribeDTCSecurityIpHostsForSQLServerResponse.DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups>();
			for (int i = 0; i < context.Length("DescribeDTCSecurityIpHostsForSQLServer.Items.Length"); i++) {
				DescribeDTCSecurityIpHostsForSQLServerResponse.DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups whiteListGroups = new DescribeDTCSecurityIpHostsForSQLServerResponse.DescribeDTCSecurityIpHostsForSQLServer_WhiteListGroups();
				whiteListGroups.SecurityIpHosts = context.StringValue("DescribeDTCSecurityIpHostsForSQLServer.Items["+ i +"].SecurityIpHosts");
				whiteListGroups.WhitelistGroupName = context.StringValue("DescribeDTCSecurityIpHostsForSQLServer.Items["+ i +"].WhitelistGroupName");

				describeDTCSecurityIpHostsForSQLServerResponse_items.Add(whiteListGroups);
			}
			describeDTCSecurityIpHostsForSQLServerResponse.Items = describeDTCSecurityIpHostsForSQLServerResponse_items;
        
			return describeDTCSecurityIpHostsForSQLServerResponse;
        }
    }
}
