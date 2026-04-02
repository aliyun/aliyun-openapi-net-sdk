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
    public class GetDestinationCidrBlockResponseUnmarshaller
    {
        public static GetDestinationCidrBlockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDestinationCidrBlockResponse getDestinationCidrBlockResponse = new GetDestinationCidrBlockResponse();

			getDestinationCidrBlockResponse.HttpResponse = _ctx.HttpResponse;
			getDestinationCidrBlockResponse.Code = _ctx.IntegerValue("GetDestinationCidrBlock.Code");
			getDestinationCidrBlockResponse.Message = _ctx.StringValue("GetDestinationCidrBlock.Message");
			getDestinationCidrBlockResponse.RequestId = _ctx.StringValue("GetDestinationCidrBlock.RequestId");
			getDestinationCidrBlockResponse.AccessDeniedDetail = _ctx.StringValue("GetDestinationCidrBlock.AccessDeniedDetail");

			GetDestinationCidrBlockResponse.GetDestinationCidrBlock_Content content = new GetDestinationCidrBlockResponse.GetDestinationCidrBlock_Content();

			List<string> content_destinationCidrBlock = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDestinationCidrBlock.Content.DestinationCidrBlock.Length"); i++) {
				content_destinationCidrBlock.Add(_ctx.StringValue("GetDestinationCidrBlock.Content.DestinationCidrBlock["+ i +"]"));
			}
			content.DestinationCidrBlock = content_destinationCidrBlock;
			getDestinationCidrBlockResponse.Content = content;
        
			return getDestinationCidrBlockResponse;
        }
    }
}
