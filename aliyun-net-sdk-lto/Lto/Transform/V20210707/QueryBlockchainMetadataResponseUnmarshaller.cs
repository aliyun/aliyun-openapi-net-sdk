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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class QueryBlockchainMetadataResponseUnmarshaller
    {
        public static QueryBlockchainMetadataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBlockchainMetadataResponse queryBlockchainMetadataResponse = new QueryBlockchainMetadataResponse();

			queryBlockchainMetadataResponse.HttpResponse = _ctx.HttpResponse;
			queryBlockchainMetadataResponse.Code = _ctx.StringValue("QueryBlockchainMetadata.Code");
			queryBlockchainMetadataResponse.Message = _ctx.StringValue("QueryBlockchainMetadata.Message");
			queryBlockchainMetadataResponse.RequestId = _ctx.StringValue("QueryBlockchainMetadata.RequestId");
			queryBlockchainMetadataResponse.Success = _ctx.BooleanValue("QueryBlockchainMetadata.Success");

			QueryBlockchainMetadataResponse.QueryBlockchainMetadata_Data data = new QueryBlockchainMetadataResponse.QueryBlockchainMetadata_Data();
			data.ProductKey = _ctx.StringValue("QueryBlockchainMetadata.Data.ProductKey");
			data.MemberName = _ctx.StringValue("QueryBlockchainMetadata.Data.MemberName");
			data.Timestamp = _ctx.LongValue("QueryBlockchainMetadata.Data.Timestamp");
			data.TxHash = _ctx.StringValue("QueryBlockchainMetadata.Data.TxHash");
			data.BlockHash = _ctx.StringValue("QueryBlockchainMetadata.Data.BlockHash");
			data.BlockNumber = _ctx.StringValue("QueryBlockchainMetadata.Data.BlockNumber");
			data.IotId = _ctx.StringValue("QueryBlockchainMetadata.Data.IotId");
			queryBlockchainMetadataResponse.Data = data;
        
			return queryBlockchainMetadataResponse;
        }
    }
}
