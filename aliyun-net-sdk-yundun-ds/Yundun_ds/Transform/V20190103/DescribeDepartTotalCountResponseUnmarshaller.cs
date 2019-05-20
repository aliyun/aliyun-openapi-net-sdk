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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeDepartTotalCountResponseUnmarshaller
    {
        public static DescribeDepartTotalCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDepartTotalCountResponse describeDepartTotalCountResponse = new DescribeDepartTotalCountResponse();

			describeDepartTotalCountResponse.HttpResponse = context.HttpResponse;
			describeDepartTotalCountResponse.RequestId = context.StringValue("DescribeDepartTotalCount.RequestId");

			DescribeDepartTotalCountResponse.DescribeDepartTotalCount_DepartCount departCount = new DescribeDepartTotalCountResponse.DescribeDepartTotalCount_DepartCount();
			departCount.DepartCount = context.LongValue("DescribeDepartTotalCount.DepartCount.DepartCount");
			departCount.Count = context.LongValue("DescribeDepartTotalCount.DepartCount.Count");
			departCount.UserCount = context.LongValue("DescribeDepartTotalCount.DepartCount.UserCount");
			departCount.DtCount = context.LongValue("DescribeDepartTotalCount.DepartCount.DtCount");
			departCount.SubCount = context.LongValue("DescribeDepartTotalCount.DepartCount.SubCount");
			departCount.SensitiveCount = context.LongValue("DescribeDepartTotalCount.DepartCount.SensitiveCount");
			describeDepartTotalCountResponse.DepartCount = departCount;
        
			return describeDepartTotalCountResponse;
        }
    }
}
