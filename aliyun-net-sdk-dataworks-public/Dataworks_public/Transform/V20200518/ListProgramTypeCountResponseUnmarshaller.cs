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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListProgramTypeCountResponseUnmarshaller
    {
        public static ListProgramTypeCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProgramTypeCountResponse listProgramTypeCountResponse = new ListProgramTypeCountResponse();

			listProgramTypeCountResponse.HttpResponse = _ctx.HttpResponse;
			listProgramTypeCountResponse.RequestId = _ctx.StringValue("ListProgramTypeCount.RequestId");

			List<ListProgramTypeCountResponse.ListProgramTypeCount_ProgramTypeAndCount> listProgramTypeCountResponse_programTypeAndCounts = new List<ListProgramTypeCountResponse.ListProgramTypeCount_ProgramTypeAndCount>();
			for (int i = 0; i < _ctx.Length("ListProgramTypeCount.ProgramTypeAndCounts.Length"); i++) {
				ListProgramTypeCountResponse.ListProgramTypeCount_ProgramTypeAndCount programTypeAndCount = new ListProgramTypeCountResponse.ListProgramTypeCount_ProgramTypeAndCount();
				programTypeAndCount.ProgramType = _ctx.StringValue("ListProgramTypeCount.ProgramTypeAndCounts["+ i +"].ProgramType");
				programTypeAndCount.Count = _ctx.IntegerValue("ListProgramTypeCount.ProgramTypeAndCounts["+ i +"].Count");

				listProgramTypeCountResponse_programTypeAndCounts.Add(programTypeAndCount);
			}
			listProgramTypeCountResponse.ProgramTypeAndCounts = listProgramTypeCountResponse_programTypeAndCounts;
        
			return listProgramTypeCountResponse;
        }
    }
}
