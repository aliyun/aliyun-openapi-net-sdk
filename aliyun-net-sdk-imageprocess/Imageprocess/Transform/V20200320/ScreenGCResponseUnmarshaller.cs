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
    public class ScreenGCResponseUnmarshaller
    {
        public static ScreenGCResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScreenGCResponse screenGCResponse = new ScreenGCResponse();

			screenGCResponse.HttpResponse = _ctx.HttpResponse;
			screenGCResponse.RequestId = _ctx.StringValue("ScreenGC.RequestId");
			screenGCResponse.Code = _ctx.StringValue("ScreenGC.Code");
			screenGCResponse.Message = _ctx.StringValue("ScreenGC.Message");

			ScreenGCResponse.ScreenGC_Data data = new ScreenGCResponse.ScreenGC_Data();

			ScreenGCResponse.ScreenGC_Data.ScreenGC_Lesion lesion = new ScreenGCResponse.ScreenGC_Data.ScreenGC_Lesion();
			lesion.Probabilities = _ctx.StringValue("ScreenGC.Data.Lesion.Probabilities");
			lesion.Stage2Volume = _ctx.StringValue("ScreenGC.Data.Lesion.Stage2Volume");
			lesion.StomachVolume = _ctx.StringValue("ScreenGC.Data.Lesion.StomachVolume");
			lesion.GCVolume = _ctx.StringValue("ScreenGC.Data.Lesion.GCVolume");
			lesion.NonGCVolume = _ctx.StringValue("ScreenGC.Data.Lesion.NonGCVolume");
			lesion.Mask = _ctx.StringValue("ScreenGC.Data.Lesion.Mask");
			data.Lesion = lesion;
			screenGCResponse.Data = data;
        
			return screenGCResponse;
        }
    }
}
