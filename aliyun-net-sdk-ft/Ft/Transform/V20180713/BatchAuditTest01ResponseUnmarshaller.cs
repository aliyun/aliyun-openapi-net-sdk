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
using Aliyun.Acs.Ft.Model.V20180713;

namespace Aliyun.Acs.Ft.Transform.V20180713
{
    public class BatchAuditTest01ResponseUnmarshaller
    {
        public static BatchAuditTest01Response Unmarshall(UnmarshallerContext _ctx)
        {
			BatchAuditTest01Response batchAuditTest01Response = new BatchAuditTest01Response();

			batchAuditTest01Response.HttpResponse = _ctx.HttpResponse;
			batchAuditTest01Response.RequestId = _ctx.StringValue("BatchAuditTest01.RequestId");
			batchAuditTest01Response.Name = _ctx.StringValue("BatchAuditTest01.Name");

			BatchAuditTest01Response.BatchAuditTest01_Demo01 demo01 = new BatchAuditTest01Response.BatchAuditTest01_Demo01();

			List<BatchAuditTest01Response.BatchAuditTest01_Demo01.BatchAuditTest01_Demo011Item> demo01_demo011 = new List<BatchAuditTest01Response.BatchAuditTest01_Demo01.BatchAuditTest01_Demo011Item>();
			for (int i = 0; i < _ctx.Length("BatchAuditTest01.Demo01.Demo011.Length"); i++) {
				BatchAuditTest01Response.BatchAuditTest01_Demo01.BatchAuditTest01_Demo011Item demo011Item = new BatchAuditTest01Response.BatchAuditTest01_Demo01.BatchAuditTest01_Demo011Item();
				demo011Item.Demo0111 = _ctx.StringValue("BatchAuditTest01.Demo01.Demo011["+ i +"].Demo0111");

				demo01_demo011.Add(demo011Item);
			}
			demo01.Demo011 = demo01_demo011;
			batchAuditTest01Response.Demo01 = demo01;
        
			return batchAuditTest01Response;
        }
    }
}
