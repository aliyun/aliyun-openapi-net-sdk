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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class BatchPatentAddResponseUnmarshaller
    {
        public static BatchPatentAddResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchPatentAddResponse batchPatentAddResponse = new BatchPatentAddResponse();

			batchPatentAddResponse.HttpResponse = _ctx.HttpResponse;
			batchPatentAddResponse.RequestId = _ctx.StringValue("BatchPatentAdd.RequestId");
			batchPatentAddResponse.Success = _ctx.BooleanValue("BatchPatentAdd.Success");

			List<BatchPatentAddResponse.BatchPatentAdd_DataItem> batchPatentAddResponse_data = new List<BatchPatentAddResponse.BatchPatentAdd_DataItem>();
			for (int i = 0; i < _ctx.Length("BatchPatentAdd.Data.Length"); i++) {
				BatchPatentAddResponse.BatchPatentAdd_DataItem dataItem = new BatchPatentAddResponse.BatchPatentAdd_DataItem();
				dataItem.ApplyNumber = _ctx.StringValue("BatchPatentAdd.Data["+ i +"].ApplyNumber");
				dataItem.Message = _ctx.StringValue("BatchPatentAdd.Data["+ i +"].Message");
				dataItem.Success = _ctx.BooleanValue("BatchPatentAdd.Data["+ i +"].Success");

				batchPatentAddResponse_data.Add(dataItem);
			}
			batchPatentAddResponse.Data = batchPatentAddResponse_data;
        
			return batchPatentAddResponse;
        }
    }
}
