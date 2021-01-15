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
    public class ModifyFirstRankResponseUnmarshaller
    {
        public static ModifyFirstRankResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyFirstRankResponse modifyFirstRankResponse = new ModifyFirstRankResponse();

			modifyFirstRankResponse.HttpResponse = _ctx.HttpResponse;
			modifyFirstRankResponse.RequestId = _ctx.StringValue("ModifyFirstRank.requestId");

			ModifyFirstRankResponse.ModifyFirstRank_Result result = new ModifyFirstRankResponse.ModifyFirstRank_Result();
			result.Name = _ctx.StringValue("ModifyFirstRank.Result.name");
			result.Description = _ctx.StringValue("ModifyFirstRank.Result.description");
			result.Active = _ctx.BooleanValue("ModifyFirstRank.Result.active");

			List<ModifyFirstRankResponse.ModifyFirstRank_Result.ModifyFirstRank_MetaItem> result_meta = new List<ModifyFirstRankResponse.ModifyFirstRank_Result.ModifyFirstRank_MetaItem>();
			for (int i = 0; i < _ctx.Length("ModifyFirstRank.Result.Meta.Length"); i++) {
				ModifyFirstRankResponse.ModifyFirstRank_Result.ModifyFirstRank_MetaItem metaItem = new ModifyFirstRankResponse.ModifyFirstRank_Result.ModifyFirstRank_MetaItem();
				metaItem.Attribute = _ctx.StringValue("ModifyFirstRank.Result.Meta["+ i +"].attribute");
				metaItem.Arg = _ctx.StringValue("ModifyFirstRank.Result.Meta["+ i +"].arg");
				metaItem.Weight = _ctx.FloatValue("ModifyFirstRank.Result.Meta["+ i +"].weight");

				result_meta.Add(metaItem);
			}
			result.Meta = result_meta;
			modifyFirstRankResponse.Result = result;
        
			return modifyFirstRankResponse;
        }
    }
}
