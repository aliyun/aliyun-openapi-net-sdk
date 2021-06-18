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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeBackupClientsResponseUnmarshaller
    {
        public static DescribeBackupClientsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupClientsResponse describeBackupClientsResponse = new DescribeBackupClientsResponse();

			describeBackupClientsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupClientsResponse.RequestId = _ctx.StringValue("DescribeBackupClients.RequestId");

			List<DescribeBackupClientsResponse.DescribeBackupClients_BackupMachineDTO> describeBackupClientsResponse_clients = new List<DescribeBackupClientsResponse.DescribeBackupClients_BackupMachineDTO>();
			for (int i = 0; i < _ctx.Length("DescribeBackupClients.Clients.Length"); i++) {
				DescribeBackupClientsResponse.DescribeBackupClients_BackupMachineDTO backupMachineDTO = new DescribeBackupClientsResponse.DescribeBackupClients_BackupMachineDTO();
				backupMachineDTO.Uuid = _ctx.StringValue("DescribeBackupClients.Clients["+ i +"].Uuid");
				backupMachineDTO.InstanceId = _ctx.StringValue("DescribeBackupClients.Clients["+ i +"].InstanceId");
				backupMachineDTO.ClientId = _ctx.StringValue("DescribeBackupClients.Clients["+ i +"].ClientId");
				backupMachineDTO.ClientStatus = _ctx.StringValue("DescribeBackupClients.Clients["+ i +"].ClientStatus");

				describeBackupClientsResponse_clients.Add(backupMachineDTO);
			}
			describeBackupClientsResponse.Clients = describeBackupClientsResponse_clients;
        
			return describeBackupClientsResponse;
        }
    }
}
