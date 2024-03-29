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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainMappingResponseUnmarshaller
    {
        public static DescribeLiveDomainMappingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainMappingResponse describeLiveDomainMappingResponse = new DescribeLiveDomainMappingResponse();

			describeLiveDomainMappingResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainMappingResponse.RequestId = _ctx.StringValue("DescribeLiveDomainMapping.RequestId");

			List<DescribeLiveDomainMappingResponse.DescribeLiveDomainMapping_LiveDomainModel> describeLiveDomainMappingResponse_liveDomainModels = new List<DescribeLiveDomainMappingResponse.DescribeLiveDomainMapping_LiveDomainModel>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainMapping.LiveDomainModels.Length"); i++) {
				DescribeLiveDomainMappingResponse.DescribeLiveDomainMapping_LiveDomainModel liveDomainModel = new DescribeLiveDomainMappingResponse.DescribeLiveDomainMapping_LiveDomainModel();
				liveDomainModel.Type = _ctx.StringValue("DescribeLiveDomainMapping.LiveDomainModels["+ i +"].Type");
				liveDomainModel.DomainName = _ctx.StringValue("DescribeLiveDomainMapping.LiveDomainModels["+ i +"].DomainName");

				describeLiveDomainMappingResponse_liveDomainModels.Add(liveDomainModel);
			}
			describeLiveDomainMappingResponse.LiveDomainModels = describeLiveDomainMappingResponse_liveDomainModels;
        
			return describeLiveDomainMappingResponse;
        }
    }
}
