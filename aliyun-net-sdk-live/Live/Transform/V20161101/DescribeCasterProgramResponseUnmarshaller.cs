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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterProgramResponseUnmarshaller
    {
        public static DescribeCasterProgramResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCasterProgramResponse describeCasterProgramResponse = new DescribeCasterProgramResponse();

			describeCasterProgramResponse.HttpResponse = context.HttpResponse;
			describeCasterProgramResponse.RequestId = context.StringValue("DescribeCasterProgram.RequestId");
			describeCasterProgramResponse.CasterId = context.StringValue("DescribeCasterProgram.CasterId");
			describeCasterProgramResponse.ProgramName = context.StringValue("DescribeCasterProgram.ProgramName");
			describeCasterProgramResponse.ProgramEffect = context.IntegerValue("DescribeCasterProgram.ProgramEffect");
			describeCasterProgramResponse.Total = context.IntegerValue("DescribeCasterProgram.Total");

			List<DescribeCasterProgramResponse.DescribeCasterProgram_Episode> describeCasterProgramResponse_episodes = new List<DescribeCasterProgramResponse.DescribeCasterProgram_Episode>();
			for (int i = 0; i < context.Length("DescribeCasterProgram.Episodes.Length"); i++) {
				DescribeCasterProgramResponse.DescribeCasterProgram_Episode episode = new DescribeCasterProgramResponse.DescribeCasterProgram_Episode();
				episode.EpisodeId = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].EpisodeId");
				episode.EpisodeType = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].EpisodeType");
				episode.EpisodeName = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].EpisodeName");
				episode.ResourceId = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].ResourceId");
				episode.StartTime = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].StartTime");
				episode.EndTime = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].EndTime");
				episode.SwitchType = context.StringValue("DescribeCasterProgram.Episodes["+ i +"].SwitchType");
				episode.Status = context.IntegerValue("DescribeCasterProgram.Episodes["+ i +"].Status");

				List<string> episode_componentIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeCasterProgram.Episodes["+ i +"].ComponentIds.Length"); j++) {
					episode_componentIds.Add(context.StringValue("DescribeCasterProgram.Episodes["+ i +"].ComponentIds["+ j +"]"));
				}
				episode.ComponentIds = episode_componentIds;

				describeCasterProgramResponse_episodes.Add(episode);
			}
			describeCasterProgramResponse.Episodes = describeCasterProgramResponse_episodes;
        
			return describeCasterProgramResponse;
        }
    }
}