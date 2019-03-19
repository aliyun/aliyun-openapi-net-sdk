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
using Aliyun.Acs.cloudwf.Model.V20170328;

namespace Aliyun.Acs.cloudwf.Transform.V20170328
{
    public class GetSidsAndGids4BidResponseUnmarshaller
    {
        public static GetSidsAndGids4BidResponse Unmarshall(UnmarshallerContext context)
        {
			GetSidsAndGids4BidResponse getSidsAndGids4BidResponse = new GetSidsAndGids4BidResponse();

			getSidsAndGids4BidResponse.HttpResponse = context.HttpResponse;
			getSidsAndGids4BidResponse.RequestId = context.StringValue("GetSidsAndGids4Bid.RequestId");
			getSidsAndGids4BidResponse.Success = context.BooleanValue("GetSidsAndGids4Bid.Success");
			getSidsAndGids4BidResponse.Message = context.StringValue("GetSidsAndGids4Bid.Message");
			getSidsAndGids4BidResponse.Data = context.StringValue("GetSidsAndGids4Bid.Data");
			getSidsAndGids4BidResponse.ErrorCode = context.IntegerValue("GetSidsAndGids4Bid.ErrorCode");
			getSidsAndGids4BidResponse.ErrorMsg = context.StringValue("GetSidsAndGids4Bid.ErrorMsg");
        
			return getSidsAndGids4BidResponse;
        }
    }
}
