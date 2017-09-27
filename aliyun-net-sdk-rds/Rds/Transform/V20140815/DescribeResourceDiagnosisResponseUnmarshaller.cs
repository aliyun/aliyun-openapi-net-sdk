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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeResourceDiagnosisResponseUnmarshaller
    {
        public static DescribeResourceDiagnosisResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResourceDiagnosisResponse describeResourceDiagnosisResponse = new DescribeResourceDiagnosisResponse();

			describeResourceDiagnosisResponse.HttpResponse = context.HttpResponse;
			describeResourceDiagnosisResponse.RequestId = context.StringValue("DescribeResourceDiagnosis.RequestId");
			describeResourceDiagnosisResponse.StartTime = context.StringValue("DescribeResourceDiagnosis.StartTime");
			describeResourceDiagnosisResponse.EndTime = context.StringValue("DescribeResourceDiagnosis.EndTime");

			List<string> describeResourceDiagnosisResponse_cPU = new List<string>();
			for (int i = 0; i < context.Length("DescribeResourceDiagnosis.CPU.Length"); i++) {
				describeResourceDiagnosisResponse_cPU.Add(context.StringValue("DescribeResourceDiagnosis.CPU["+ i +"]"));
			}
			describeResourceDiagnosisResponse.CPU = describeResourceDiagnosisResponse_cPU;

			List<string> describeResourceDiagnosisResponse_memory = new List<string>();
			for (int i = 0; i < context.Length("DescribeResourceDiagnosis.Memory.Length"); i++) {
				describeResourceDiagnosisResponse_memory.Add(context.StringValue("DescribeResourceDiagnosis.Memory["+ i +"]"));
			}
			describeResourceDiagnosisResponse.Memory = describeResourceDiagnosisResponse_memory;

			List<string> describeResourceDiagnosisResponse_storage = new List<string>();
			for (int i = 0; i < context.Length("DescribeResourceDiagnosis.Storage.Length"); i++) {
				describeResourceDiagnosisResponse_storage.Add(context.StringValue("DescribeResourceDiagnosis.Storage["+ i +"]"));
			}
			describeResourceDiagnosisResponse.Storage = describeResourceDiagnosisResponse_storage;

			List<string> describeResourceDiagnosisResponse_iOPS = new List<string>();
			for (int i = 0; i < context.Length("DescribeResourceDiagnosis.IOPS.Length"); i++) {
				describeResourceDiagnosisResponse_iOPS.Add(context.StringValue("DescribeResourceDiagnosis.IOPS["+ i +"]"));
			}
			describeResourceDiagnosisResponse.IOPS = describeResourceDiagnosisResponse_iOPS;

			List<string> describeResourceDiagnosisResponse_connection = new List<string>();
			for (int i = 0; i < context.Length("DescribeResourceDiagnosis.Connection.Length"); i++) {
				describeResourceDiagnosisResponse_connection.Add(context.StringValue("DescribeResourceDiagnosis.Connection["+ i +"]"));
			}
			describeResourceDiagnosisResponse.Connection = describeResourceDiagnosisResponse_connection;
        
			return describeResourceDiagnosisResponse;
        }
    }
}