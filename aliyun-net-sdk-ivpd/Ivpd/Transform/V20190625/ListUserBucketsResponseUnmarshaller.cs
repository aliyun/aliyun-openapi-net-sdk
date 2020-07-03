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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class ListUserBucketsResponseUnmarshaller
    {
        public static ListUserBucketsResponse Unmarshall(UnmarshallerContext context)
        {
			ListUserBucketsResponse listUserBucketsResponse = new ListUserBucketsResponse();

			listUserBucketsResponse.HttpResponse = context.HttpResponse;
			listUserBucketsResponse.RequestId = context.StringValue("ListUserBuckets.RequestId");
			listUserBucketsResponse.Code = context.StringValue("ListUserBuckets.Code");
			listUserBucketsResponse.Message = context.StringValue("ListUserBuckets.Message");

			List<string> listUserBucketsResponse_data = new List<string>();
			for (int i = 0; i < context.Length("ListUserBuckets.Data.Length"); i++) {
				listUserBucketsResponse_data.Add(context.StringValue("ListUserBuckets.Data["+ i +"]"));
			}
			listUserBucketsResponse.Data = listUserBucketsResponse_data;
        
			return listUserBucketsResponse;
        }
    }
}
