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
    public class DetectPancResponseUnmarshaller
    {
        public static DetectPancResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectPancResponse detectPancResponse = new DetectPancResponse();

			detectPancResponse.HttpResponse = _ctx.HttpResponse;
			detectPancResponse.RequestId = _ctx.StringValue("DetectPanc.RequestId");
			detectPancResponse.Code = _ctx.StringValue("DetectPanc.Code");
			detectPancResponse.Message = _ctx.StringValue("DetectPanc.Message");

			DetectPancResponse.DetectPanc_Data data = new DetectPancResponse.DetectPanc_Data();

			DetectPancResponse.DetectPanc_Data.DetectPanc_Lesion lesion = new DetectPancResponse.DetectPanc_Data.DetectPanc_Lesion();
			lesion.PancVol = _ctx.StringValue("DetectPanc.Data.Lesion.PancVol");
			lesion.PdacVol = _ctx.StringValue("DetectPanc.Data.Lesion.PdacVol");
			lesion.NonPdacVol = _ctx.StringValue("DetectPanc.Data.Lesion.NonPdacVol");
			lesion.Mask = _ctx.StringValue("DetectPanc.Data.Lesion.Mask");

			List<string> lesion_possibilities = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectPanc.Data.Lesion.Possibilities.Length"); i++) {
				lesion_possibilities.Add(_ctx.StringValue("DetectPanc.Data.Lesion.Possibilities["+ i +"]"));
			}
			lesion.Possibilities = lesion_possibilities;
			data.Lesion = lesion;
			detectPancResponse.Data = data;
        
			return detectPancResponse;
        }
    }
}
