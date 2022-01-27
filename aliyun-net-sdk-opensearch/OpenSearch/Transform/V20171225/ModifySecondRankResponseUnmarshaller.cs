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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ModifySecondRankResponseUnmarshaller
    {
        public static ModifySecondRankResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySecondRankResponse modifySecondRankResponse = new ModifySecondRankResponse();

			modifySecondRankResponse.HttpResponse = _ctx.HttpResponse;
			modifySecondRankResponse.RequestId = _ctx.StringValue("ModifySecondRank.requestId");

			ModifySecondRankResponse.ModifySecondRank_Result result = new ModifySecondRankResponse.ModifySecondRank_Result();
			result.Id = _ctx.StringValue("ModifySecondRank.Result.id");
			result.Name = _ctx.StringValue("ModifySecondRank.Result.name");
			result.Meta = _ctx.StringValue("ModifySecondRank.Result.meta");
			result.Active = _ctx.BooleanValue("ModifySecondRank.Result.active");
			result.Description = _ctx.StringValue("ModifySecondRank.Result.description");
			result.Created = _ctx.IntegerValue("ModifySecondRank.Result.created");
			result.Updated = _ctx.IntegerValue("ModifySecondRank.Result.updated");
			result.IsDefault = _ctx.StringValue("ModifySecondRank.Result.isDefault");
			result.IsSys = _ctx.StringValue("ModifySecondRank.Result.isSys");
			modifySecondRankResponse.Result = result;
        
			return modifySecondRankResponse;
        }
    }
}
