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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterMigrationResponseUnmarshaller
    {
        public static DescribeDBClusterMigrationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClusterMigrationResponse describeDBClusterMigrationResponse = new DescribeDBClusterMigrationResponse();

			describeDBClusterMigrationResponse.HttpResponse = context.HttpResponse;
			describeDBClusterMigrationResponse.RequestId = context.StringValue("DescribeDBClusterMigration.RequestId");
			describeDBClusterMigrationResponse.DBClusterId = context.StringValue("DescribeDBClusterMigration.DBClusterId");
			describeDBClusterMigrationResponse.SourceRDSDBInstanceId = context.StringValue("DescribeDBClusterMigration.SourceRDSDBInstanceId");
			describeDBClusterMigrationResponse.MigrationStatus = context.StringValue("DescribeDBClusterMigration.MigrationStatus");
			describeDBClusterMigrationResponse.Topologies = context.StringValue("DescribeDBClusterMigration.Topologies");
			describeDBClusterMigrationResponse.DelayedSeconds = context.IntegerValue("DescribeDBClusterMigration.DelayedSeconds");
			describeDBClusterMigrationResponse.ExpiredTime = context.StringValue("DescribeDBClusterMigration.ExpiredTime");
			describeDBClusterMigrationResponse.RdsReadWriteMode = context.StringValue("DescribeDBClusterMigration.RdsReadWriteMode");
			describeDBClusterMigrationResponse.DBClusterReadWriteMode = context.StringValue("DescribeDBClusterMigration.DBClusterReadWriteMode");
			describeDBClusterMigrationResponse.Comment = context.StringValue("DescribeDBClusterMigration.Comment");

			List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint> describeDBClusterMigrationResponse_dBClusterEndpointList = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint>();
			for (int i = 0; i < context.Length("DescribeDBClusterMigration.DBClusterEndpointList.Length"); i++) {
				DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint dBClusterEndpoint = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint();
				dBClusterEndpoint.DBEndpointId = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].DBEndpointId");
				dBClusterEndpoint.EndpointType = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].EndpointType");

				List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address> dBClusterEndpoint_addressItems = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address>();
				for (int j = 0; j < context.Length("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems.Length"); j++) {
					DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address address = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address();
					address.ConnectionString = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].ConnectionString");
					address.IPAddress = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].IPAddress");
					address.NetType = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].NetType");
					address.Port = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].Port");
					address.VPCId = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].VPCId");
					address.VSwitchId = context.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].VSwitchId");

					dBClusterEndpoint_addressItems.Add(address);
				}
				dBClusterEndpoint.AddressItems = dBClusterEndpoint_addressItems;

				describeDBClusterMigrationResponse_dBClusterEndpointList.Add(dBClusterEndpoint);
			}
			describeDBClusterMigrationResponse.DBClusterEndpointList = describeDBClusterMigrationResponse_dBClusterEndpointList;

			List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint> describeDBClusterMigrationResponse_rdsEndpointList = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint>();
			for (int i = 0; i < context.Length("DescribeDBClusterMigration.RdsEndpointList.Length"); i++) {
				DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint rdsEndpoint = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint();
				rdsEndpoint.DBEndpointId = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].DBEndpointId");
				rdsEndpoint.EndpointType = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].EndpointType");

				List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2> rdsEndpoint_addressItems1 = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2>();
				for (int j = 0; j < context.Length("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems.Length"); j++) {
					DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2 address2 = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2();
					address2.ConnectionString = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].ConnectionString");
					address2.IPAddress = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].IPAddress");
					address2.NetType = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].NetType");
					address2.Port = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].Port");
					address2.VPCId = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].VPCId");
					address2.VSwitchId = context.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].VSwitchId");

					rdsEndpoint_addressItems1.Add(address2);
				}
				rdsEndpoint.AddressItems1 = rdsEndpoint_addressItems1;

				describeDBClusterMigrationResponse_rdsEndpointList.Add(rdsEndpoint);
			}
			describeDBClusterMigrationResponse.RdsEndpointList = describeDBClusterMigrationResponse_rdsEndpointList;
        
			return describeDBClusterMigrationResponse;
        }
    }
}
