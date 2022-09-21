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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class ScreenECResponseUnmarshaller
    {
        public static ScreenECResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScreenECResponse screenECResponse = new ScreenECResponse();

			screenECResponse.HttpResponse = _ctx.HttpResponse;
			screenECResponse.RequestId = _ctx.StringValue("ScreenEC.RequestId");
			screenECResponse.Code = _ctx.StringValue("ScreenEC.Code");
			screenECResponse.Message = _ctx.StringValue("ScreenEC.Message");

			ScreenECResponse.ScreenEC_Data data = new ScreenECResponse.ScreenEC_Data();

			ScreenECResponse.ScreenEC_Data.ScreenEC_Lesion lesion = new ScreenECResponse.ScreenEC_Data.ScreenEC_Lesion();
			lesion.EsoVolume = _ctx.StringValue("ScreenEC.Data.Lesion.EsoVolume");
			lesion.EcVolume = _ctx.StringValue("ScreenEC.Data.Lesion.EcVolume");
			lesion.BenignVolume = _ctx.StringValue("ScreenEC.Data.Lesion.BenignVolume");
			lesion.Mask = _ctx.StringValue("ScreenEC.Data.Lesion.Mask");

			List<string> lesion_possibilities = new List<string>();
			for (int i = 0; i < _ctx.Length("ScreenEC.Data.Lesion.Possibilities.Length"); i++) {
				lesion_possibilities.Add(_ctx.StringValue("ScreenEC.Data.Lesion.Possibilities["+ i +"]"));
			}
			lesion.Possibilities = lesion_possibilities;
			data.Lesion = lesion;
			screenECResponse.Data = data;
        
			return screenECResponse;
        }
    }
}
