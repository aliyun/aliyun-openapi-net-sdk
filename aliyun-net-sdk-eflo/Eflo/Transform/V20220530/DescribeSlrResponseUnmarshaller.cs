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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class DescribeSlrResponseUnmarshaller
    {
        public static DescribeSlrResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlrResponse describeSlrResponse = new DescribeSlrResponse();

			describeSlrResponse.HttpResponse = _ctx.HttpResponse;
			describeSlrResponse.Code = _ctx.IntegerValue("DescribeSlr.Code");
			describeSlrResponse.Message = _ctx.StringValue("DescribeSlr.Message");
			describeSlrResponse.RequestId = _ctx.StringValue("DescribeSlr.RequestId");

			DescribeSlrResponse.DescribeSlr_Content content = new DescribeSlrResponse.DescribeSlr_Content();
			content.HasRole = _ctx.BooleanValue("DescribeSlr.Content.HasRole");
			describeSlrResponse.Content = content;
        
			return describeSlrResponse;
        }
    }
}
