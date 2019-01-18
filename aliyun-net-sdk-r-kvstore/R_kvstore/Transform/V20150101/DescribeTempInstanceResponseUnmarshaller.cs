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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeTempInstanceResponseUnmarshaller
    {
        public static DescribeTempInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTempInstanceResponse describeTempInstanceResponse = new DescribeTempInstanceResponse();

			describeTempInstanceResponse.HttpResponse = context.HttpResponse;
			describeTempInstanceResponse.RequestId = context.StringValue("DescribeTempInstance.RequestId");

			List<DescribeTempInstanceResponse.DescribeTempInstance_TempInstance> describeTempInstanceResponse_tempInstances = new List<DescribeTempInstanceResponse.DescribeTempInstance_TempInstance>();
			for (int i = 0; i < context.Length("DescribeTempInstance.TempInstances.Length"); i++) {
				DescribeTempInstanceResponse.DescribeTempInstance_TempInstance tempInstance = new DescribeTempInstanceResponse.DescribeTempInstance_TempInstance();
				tempInstance.InstanceId = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].InstanceId");
				tempInstance.TempInstanceId = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].TempInstanceId");
				tempInstance.SnapshotId = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].SnapshotId");
				tempInstance.CreateTime = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].CreateTime");
				tempInstance.Domain = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].Domain");
				tempInstance.Status = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].Status");
				tempInstance.Memory = context.LongValue("DescribeTempInstance.TempInstances["+ i +"].Memory");
				tempInstance.ExpireTime = context.StringValue("DescribeTempInstance.TempInstances["+ i +"].ExpireTime");

				describeTempInstanceResponse_tempInstances.Add(tempInstance);
			}
			describeTempInstanceResponse.TempInstances = describeTempInstanceResponse_tempInstances;
        
			return describeTempInstanceResponse;
        }
    }
}