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
        public static DescribeDBClusterMigrationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterMigrationResponse describeDBClusterMigrationResponse = new DescribeDBClusterMigrationResponse();

			describeDBClusterMigrationResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterMigrationResponse.Comment = _ctx.StringValue("DescribeDBClusterMigration.Comment");
			describeDBClusterMigrationResponse.RequestId = _ctx.StringValue("DescribeDBClusterMigration.RequestId");
			describeDBClusterMigrationResponse.ExpiredTime = _ctx.StringValue("DescribeDBClusterMigration.ExpiredTime");
			describeDBClusterMigrationResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterMigration.DBClusterId");
			describeDBClusterMigrationResponse.Topologies = _ctx.StringValue("DescribeDBClusterMigration.Topologies");
			describeDBClusterMigrationResponse.RdsReadWriteMode = _ctx.StringValue("DescribeDBClusterMigration.RdsReadWriteMode");
			describeDBClusterMigrationResponse.SourceRDSDBInstanceId = _ctx.StringValue("DescribeDBClusterMigration.SourceRDSDBInstanceId");
			describeDBClusterMigrationResponse.DBClusterReadWriteMode = _ctx.StringValue("DescribeDBClusterMigration.DBClusterReadWriteMode");
			describeDBClusterMigrationResponse.DelayedSeconds = _ctx.IntegerValue("DescribeDBClusterMigration.DelayedSeconds");
			describeDBClusterMigrationResponse.MigrationStatus = _ctx.StringValue("DescribeDBClusterMigration.MigrationStatus");
			describeDBClusterMigrationResponse.DtsInstanceId = _ctx.StringValue("DescribeDBClusterMigration.DtsInstanceId");
			describeDBClusterMigrationResponse.SrcDbType = _ctx.StringValue("DescribeDBClusterMigration.SrcDbType");
			describeDBClusterMigrationResponse.MigrationSwitch = _ctx.StringValue("DescribeDBClusterMigration.MigrationSwitch");
			describeDBClusterMigrationResponse.MigrationDtsJobEndpoint = _ctx.StringValue("DescribeDBClusterMigration.MigrationDtsJobEndpoint");
			describeDBClusterMigrationResponse.DstBinlogPosition = _ctx.StringValue("DescribeDBClusterMigration.DstBinlogPosition");
			describeDBClusterMigrationResponse.SrcBinlogPosition = _ctx.StringValue("DescribeDBClusterMigration.SrcBinlogPosition");
			describeDBClusterMigrationResponse.MigrationProgress = _ctx.StringValue("DescribeDBClusterMigration.MigrationProgress");

			List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint> describeDBClusterMigrationResponse_dBClusterEndpointList = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterMigration.DBClusterEndpointList.Length"); i++) {
				DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint dBClusterEndpoint = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint();
				dBClusterEndpoint.DBEndpointId = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].DBEndpointId");
				dBClusterEndpoint.EndpointType = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].EndpointType");
				dBClusterEndpoint.ReadWriteMode = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].ReadWriteMode");

				List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address> dBClusterEndpoint_addressItems = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems.Length"); j++) {
					DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address address = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DBClusterEndpoint.DescribeDBClusterMigration_Address();
					address.VSwitchId = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].VSwitchId");
					address.ConnectionString = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].ConnectionString");
					address.NetType = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].NetType");
					address.Port = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].Port");
					address.VPCId = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].VPCId");
					address.IPAddress = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].IPAddress");
					address.SSLEnabled = _ctx.StringValue("DescribeDBClusterMigration.DBClusterEndpointList["+ i +"].AddressItems["+ j +"].SSLEnabled");

					dBClusterEndpoint_addressItems.Add(address);
				}
				dBClusterEndpoint.AddressItems = dBClusterEndpoint_addressItems;

				describeDBClusterMigrationResponse_dBClusterEndpointList.Add(dBClusterEndpoint);
			}
			describeDBClusterMigrationResponse.DBClusterEndpointList = describeDBClusterMigrationResponse_dBClusterEndpointList;

			List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint> describeDBClusterMigrationResponse_rdsEndpointList = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterMigration.RdsEndpointList.Length"); i++) {
				DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint rdsEndpoint = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint();
				rdsEndpoint.DBEndpointId = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].DBEndpointId");
				rdsEndpoint.EndpointType = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].EndpointType");
				rdsEndpoint.CustinsType = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].CustinsType");

				List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2> rdsEndpoint_addressItems1 = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems.Length"); j++) {
					DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2 address2 = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_RdsEndpoint.DescribeDBClusterMigration_Address2();
					address2.VSwitchId = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].VSwitchId");
					address2.ConnectionString = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].ConnectionString");
					address2.NetType = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].NetType");
					address2.Port = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].Port");
					address2.VPCId = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].VPCId");
					address2.IPAddress = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].IPAddress");
					address2.SSLEnabled = _ctx.StringValue("DescribeDBClusterMigration.RdsEndpointList["+ i +"].AddressItems["+ j +"].SSLEnabled");

					rdsEndpoint_addressItems1.Add(address2);
				}
				rdsEndpoint.AddressItems1 = rdsEndpoint_addressItems1;

				describeDBClusterMigrationResponse_rdsEndpointList.Add(rdsEndpoint);
			}
			describeDBClusterMigrationResponse.RdsEndpointList = describeDBClusterMigrationResponse_rdsEndpointList;

			List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_SrcDtsJob> describeDBClusterMigrationResponse_srcDtsJobList = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_SrcDtsJob>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterMigration.SrcDtsJobList.Length"); i++) {
				DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_SrcDtsJob srcDtsJob = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_SrcDtsJob();
				srcDtsJob.DtsJobId = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].DtsJobId");
				srcDtsJob.DtsJobName = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].DtsJobName");
				srcDtsJob.DtsInstanceID = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].DtsInstanceID");
				srcDtsJob.DtsJobDirection = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].DtsJobDirection");
				srcDtsJob.Status = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].Status");
				srcDtsJob.SourceEndpoint = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].SourceEndpoint");
				srcDtsJob.DestinationEndpoint = _ctx.StringValue("DescribeDBClusterMigration.SrcDtsJobList["+ i +"].DestinationEndpoint");

				describeDBClusterMigrationResponse_srcDtsJobList.Add(srcDtsJob);
			}
			describeDBClusterMigrationResponse.SrcDtsJobList = describeDBClusterMigrationResponse_srcDtsJobList;

			List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DstDtsJob> describeDBClusterMigrationResponse_dstDtsJobList = new List<DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DstDtsJob>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterMigration.DstDtsJobList.Length"); i++) {
				DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DstDtsJob dstDtsJob = new DescribeDBClusterMigrationResponse.DescribeDBClusterMigration_DstDtsJob();
				dstDtsJob.DtsJobId = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].DtsJobId");
				dstDtsJob.DtsJobName = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].DtsJobName");
				dstDtsJob.DtsInstanceId = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].DtsInstanceId");
				dstDtsJob.DtsJobDirection = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].DtsJobDirection");
				dstDtsJob.Status = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].Status");
				dstDtsJob.SourceEndpoint = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].SourceEndpoint");
				dstDtsJob.DestinationEndpoint = _ctx.StringValue("DescribeDBClusterMigration.DstDtsJobList["+ i +"].DestinationEndpoint");

				describeDBClusterMigrationResponse_dstDtsJobList.Add(dstDtsJob);
			}
			describeDBClusterMigrationResponse.DstDtsJobList = describeDBClusterMigrationResponse_dstDtsJobList;
        
			return describeDBClusterMigrationResponse;
        }
    }
}
