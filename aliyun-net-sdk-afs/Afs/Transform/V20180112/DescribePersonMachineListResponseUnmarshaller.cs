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
using Aliyun.Acs.afs.Model.V20180112;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.afs.Transform.V20180112
{
    public class DescribePersonMachineListResponseUnmarshaller
    {
        public static DescribePersonMachineListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePersonMachineListResponse describePersonMachineListResponse = new DescribePersonMachineListResponse();

			describePersonMachineListResponse.HttpResponse = context.HttpResponse;
			describePersonMachineListResponse.RequestId = context.StringValue("DescribePersonMachineList.RequestId");
			describePersonMachineListResponse.BizCode = context.StringValue("DescribePersonMachineList.BizCode");

			DescribePersonMachineListResponse.DescribePersonMachineList_PersonMachineRes personMachineRes = new DescribePersonMachineListResponse.DescribePersonMachineList_PersonMachineRes();
			personMachineRes.HasConfiguration = context.StringValue("DescribePersonMachineList.PersonMachineRes.HasConfiguration");

			List<DescribePersonMachineListResponse.DescribePersonMachineList_PersonMachineRes.DescribePersonMachineList_PersonMachine> personMachineRes_personMachines = new List<DescribePersonMachineListResponse.DescribePersonMachineList_PersonMachineRes.DescribePersonMachineList_PersonMachine>();
			for (int i = 0; i < context.Length("DescribePersonMachineList.PersonMachineRes.PersonMachines.Length"); i++) {
				DescribePersonMachineListResponse.DescribePersonMachineList_PersonMachineRes.DescribePersonMachineList_PersonMachine personMachine = new DescribePersonMachineListResponse.DescribePersonMachineList_PersonMachineRes.DescribePersonMachineList_PersonMachine();
				personMachine.ConfigurationName = context.StringValue("DescribePersonMachineList.PersonMachineRes.PersonMachines["+ i +"].ConfigurationName");
				personMachine.Appkey = context.StringValue("DescribePersonMachineList.PersonMachineRes.PersonMachines["+ i +"].Appkey");
				personMachine.ConfigurationMethod = context.StringValue("DescribePersonMachineList.PersonMachineRes.PersonMachines["+ i +"].ConfigurationMethod");
				personMachine.ApplyType = context.StringValue("DescribePersonMachineList.PersonMachineRes.PersonMachines["+ i +"].ApplyType");
				personMachine.Scene = context.StringValue("DescribePersonMachineList.PersonMachineRes.PersonMachines["+ i +"].Scene");
				personMachine.LastUpdate = context.StringValue("DescribePersonMachineList.PersonMachineRes.PersonMachines["+ i +"].LastUpdate");

				personMachineRes_personMachines.Add(personMachine);
			}
			personMachineRes.PersonMachines = personMachineRes_personMachines;
			describePersonMachineListResponse.PersonMachineRes = personMachineRes;
        
			return describePersonMachineListResponse;
        }
    }
}