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
using Aliyun.Acs.smc.Model.V20190601;

namespace Aliyun.Acs.smc.Transform.V20190601
{
    public class DescribeSourceServersResponseUnmarshaller
    {
        public static DescribeSourceServersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSourceServersResponse describeSourceServersResponse = new DescribeSourceServersResponse();

			describeSourceServersResponse.HttpResponse = context.HttpResponse;
			describeSourceServersResponse.RequestId = context.StringValue("DescribeSourceServers.RequestId");
			describeSourceServersResponse.TotalCount = context.IntegerValue("DescribeSourceServers.TotalCount");
			describeSourceServersResponse.PageNumber = context.IntegerValue("DescribeSourceServers.PageNumber");
			describeSourceServersResponse.PageSize = context.IntegerValue("DescribeSourceServers.PageSize");

			List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer> describeSourceServersResponse_sourceServers = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer>();
			for (int i = 0; i < context.Length("DescribeSourceServers.SourceServers.Length"); i++) {
				DescribeSourceServersResponse.DescribeSourceServers_SourceServer sourceServer = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer();
				sourceServer.SourceId = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].SourceId");
				sourceServer.JobId = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].JobId");
				sourceServer.AgentVersion = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].AgentVersion");
				sourceServer.Name = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].Name");
				sourceServer.Description = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].Description");
				sourceServer.KernelLevel = context.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].KernelLevel");
				sourceServer.Platform = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].Platform");
				sourceServer.Architecture = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].Architecture");
				sourceServer.SystemDiskSize = context.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskSize");
				sourceServer.ReplicationDriver = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].ReplicationDriver");
				sourceServer.SystemInfo = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].SystemInfo");
				sourceServer.CreationTime = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].CreationTime");
				sourceServer.State = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].State");
				sourceServer.ErrorCode = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].ErrorCode");
				sourceServer.StatusInfo = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].StatusInfo");
				sourceServer.HeartbeatRate = context.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].HeartbeatRate");

				List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk> sourceServer_dataDisks = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk>();
				for (int j = 0; j < context.Length("DescribeSourceServers.SourceServers["+ i +"].DataDisks.Length"); j++) {
					DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk dataDisk = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk();
					dataDisk.Index = context.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Index");
					dataDisk.Size = context.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Size");
					dataDisk.Path = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Path");

					List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part> dataDisk_parts = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part>();
					for (int k = 0; k < context.Length("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts.Length"); k++) {
						DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part part = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part();
						part.Path = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Path");
						part.Device = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Device");
						part.SizeBytes = context.LongValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].SizeBytes");
						part.Need = context.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Need");
						part.CanBlock = context.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].CanBlock");

						dataDisk_parts.Add(part);
					}
					dataDisk.Parts = dataDisk_parts;

					sourceServer_dataDisks.Add(dataDisk);
				}
				sourceServer.DataDisks = sourceServer_dataDisks;

				List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart> sourceServer_systemDiskParts = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart>();
				for (int j = 0; j < context.Length("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts.Length"); j++) {
					DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart systemDiskPart = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart();
					systemDiskPart.Path = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].Path");
					systemDiskPart.Device = context.StringValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].Device");
					systemDiskPart.SizeBytes = context.LongValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].SizeBytes");
					systemDiskPart.Need = context.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].Need");
					systemDiskPart.CanBlock = context.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].CanBlock");

					sourceServer_systemDiskParts.Add(systemDiskPart);
				}
				sourceServer.SystemDiskParts = sourceServer_systemDiskParts;

				describeSourceServersResponse_sourceServers.Add(sourceServer);
			}
			describeSourceServersResponse.SourceServers = describeSourceServersResponse_sourceServers;
        
			return describeSourceServersResponse;
        }
    }
}
