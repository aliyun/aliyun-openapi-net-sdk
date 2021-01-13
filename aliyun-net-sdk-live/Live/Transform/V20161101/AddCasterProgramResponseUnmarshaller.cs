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
    public class AddCasterProgramResponseUnmarshaller
    {
        public static AddCasterProgramResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddCasterProgramResponse addCasterProgramResponse = new AddCasterProgramResponse();

			addCasterProgramResponse.HttpResponse = _ctx.HttpResponse;
			addCasterProgramResponse.RequestId = _ctx.StringValue("AddCasterProgram.RequestId");

			List<AddCasterProgramResponse.AddCasterProgram_EpisodeId> addCasterProgramResponse_episodeIds = new List<AddCasterProgramResponse.AddCasterProgram_EpisodeId>();
			for (int i = 0; i < _ctx.Length("AddCasterProgram.EpisodeIds.Length"); i++) {
				AddCasterProgramResponse.AddCasterProgram_EpisodeId episodeId = new AddCasterProgramResponse.AddCasterProgram_EpisodeId();
				episodeId.EpisodeId = _ctx.StringValue("AddCasterProgram.EpisodeIds["+ i +"].EpisodeId");

				addCasterProgramResponse_episodeIds.Add(episodeId);
			}
			addCasterProgramResponse.EpisodeIds = addCasterProgramResponse_episodeIds;
        
			return addCasterProgramResponse;
        }
    }
}
