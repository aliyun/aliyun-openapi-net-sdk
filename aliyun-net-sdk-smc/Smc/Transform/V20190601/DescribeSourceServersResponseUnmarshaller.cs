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
        public static DescribeSourceServersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSourceServersResponse describeSourceServersResponse = new DescribeSourceServersResponse();

			describeSourceServersResponse.HttpResponse = _ctx.HttpResponse;
			describeSourceServersResponse.RequestId = _ctx.StringValue("DescribeSourceServers.RequestId");
			describeSourceServersResponse.TotalCount = _ctx.IntegerValue("DescribeSourceServers.TotalCount");
			describeSourceServersResponse.PageNumber = _ctx.IntegerValue("DescribeSourceServers.PageNumber");
			describeSourceServersResponse.PageSize = _ctx.IntegerValue("DescribeSourceServers.PageSize");

			List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer> describeSourceServersResponse_sourceServers = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer>();
			for (int i = 0; i < _ctx.Length("DescribeSourceServers.SourceServers.Length"); i++) {
				DescribeSourceServersResponse.DescribeSourceServers_SourceServer sourceServer = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer();
				sourceServer.SourceId = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].SourceId");
				sourceServer.JobId = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].JobId");
				sourceServer.AgentVersion = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].AgentVersion");
				sourceServer.Name = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].Name");
				sourceServer.Description = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].Description");
				sourceServer.KernelLevel = _ctx.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].KernelLevel");
				sourceServer.Platform = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].Platform");
				sourceServer.Architecture = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].Architecture");
				sourceServer.SystemDiskSize = _ctx.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskSize");
				sourceServer.ReplicationDriver = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].ReplicationDriver");
				sourceServer.SystemInfo = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].SystemInfo");
				sourceServer.CreationTime = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].CreationTime");
				sourceServer.State = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].State");
				sourceServer.ErrorCode = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].ErrorCode");
				sourceServer.StatusInfo = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].StatusInfo");
				sourceServer.HeartbeatRate = _ctx.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].HeartbeatRate");

				List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk> sourceServer_dataDisks = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk>();
				for (int j = 0; j < _ctx.Length("DescribeSourceServers.SourceServers["+ i +"].DataDisks.Length"); j++) {
					DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk dataDisk = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk();
					dataDisk.Index = _ctx.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Index");
					dataDisk.Size = _ctx.IntegerValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Size");
					dataDisk.Path = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Path");

					List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part> dataDisk_parts = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part>();
					for (int k = 0; k < _ctx.Length("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts.Length"); k++) {
						DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part part = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_DataDisk.DescribeSourceServers_Part();
						part.Path = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Path");
						part.Device = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Device");
						part.SizeBytes = _ctx.LongValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].SizeBytes");
						part.Need = _ctx.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Need");
						part.CanBlock = _ctx.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].DataDisks["+ j +"].Parts["+ k +"].CanBlock");

						dataDisk_parts.Add(part);
					}
					dataDisk.Parts = dataDisk_parts;

					sourceServer_dataDisks.Add(dataDisk);
				}
				sourceServer.DataDisks = sourceServer_dataDisks;

				List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart> sourceServer_systemDiskParts = new List<DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart>();
				for (int j = 0; j < _ctx.Length("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts.Length"); j++) {
					DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart systemDiskPart = new DescribeSourceServersResponse.DescribeSourceServers_SourceServer.DescribeSourceServers_SystemDiskPart();
					systemDiskPart.Path = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].Path");
					systemDiskPart.Device = _ctx.StringValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].Device");
					systemDiskPart.SizeBytes = _ctx.LongValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].SizeBytes");
					systemDiskPart.Need = _ctx.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].Need");
					systemDiskPart.CanBlock = _ctx.BooleanValue("DescribeSourceServers.SourceServers["+ i +"].SystemDiskParts["+ j +"].CanBlock");

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
