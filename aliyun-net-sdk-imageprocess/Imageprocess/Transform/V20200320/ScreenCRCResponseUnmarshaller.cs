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
    public class ScreenCRCResponseUnmarshaller
    {
        public static ScreenCRCResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScreenCRCResponse screenCRCResponse = new ScreenCRCResponse();

			screenCRCResponse.HttpResponse = _ctx.HttpResponse;
			screenCRCResponse.RequestId = _ctx.StringValue("ScreenCRC.RequestId");
			screenCRCResponse.Code = _ctx.StringValue("ScreenCRC.Code");
			screenCRCResponse.Message = _ctx.StringValue("ScreenCRC.Message");

			ScreenCRCResponse.ScreenCRC_Data data = new ScreenCRCResponse.ScreenCRC_Data();

			ScreenCRCResponse.ScreenCRC_Data.ScreenCRC_Lesion lesion = new ScreenCRCResponse.ScreenCRC_Data.ScreenCRC_Lesion();
			lesion.Probabilities = _ctx.StringValue("ScreenCRC.Data.Lesion.Probabilities");
			lesion.Stage2Volume = _ctx.StringValue("ScreenCRC.Data.Lesion.Stage2Volume");
			lesion.ColorectumVolume = _ctx.StringValue("ScreenCRC.Data.Lesion.ColorectumVolume");
			lesion.CRCVolume = _ctx.StringValue("ScreenCRC.Data.Lesion.CRCVolume");
			lesion.NonCRCVolumel = _ctx.StringValue("ScreenCRC.Data.Lesion.NonCRCVolumel");
			lesion.Mask = _ctx.StringValue("ScreenCRC.Data.Lesion.Mask");
			data.Lesion = lesion;
			screenCRCResponse.Data = data;
        
			return screenCRCResponse;
        }
    }
}
