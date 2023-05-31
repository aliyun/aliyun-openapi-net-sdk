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
    public class ScreenLCResponseUnmarshaller
    {
        public static ScreenLCResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScreenLCResponse screenLCResponse = new ScreenLCResponse();

			screenLCResponse.HttpResponse = _ctx.HttpResponse;
			screenLCResponse.RequestId = _ctx.StringValue("ScreenLC.RequestId");
			screenLCResponse.Code = _ctx.StringValue("ScreenLC.Code");
			screenLCResponse.Message = _ctx.StringValue("ScreenLC.Message");

			ScreenLCResponse.ScreenLC_Data data = new ScreenLCResponse.ScreenLC_Data();

			ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion lesion = new ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion();
			lesion.Mask = _ctx.StringValue("ScreenLC.Data.Lesion.Mask");
			lesion.LiverVolume = _ctx.FloatValue("ScreenLC.Data.Lesion.LiverVolume");

			ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion.ScreenLC_PatientLevelResult patientLevelResult = new ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion.ScreenLC_PatientLevelResult();
			patientLevelResult.TumorNonCystProb = _ctx.FloatValue("ScreenLC.Data.Lesion.PatientLevelResult.TumorNonCystProb");
			patientLevelResult.HCCProb = _ctx.FloatValue("ScreenLC.Data.Lesion.PatientLevelResult.HCCProb");
			patientLevelResult.MalignantNonHCCProb = _ctx.FloatValue("ScreenLC.Data.Lesion.PatientLevelResult.MalignantNonHCCProb");
			patientLevelResult.BenignNonCystProb = _ctx.StringValue("ScreenLC.Data.Lesion.PatientLevelResult.BenignNonCystProb");
			patientLevelResult.CystProb = _ctx.FloatValue("ScreenLC.Data.Lesion.PatientLevelResult.CystProb");
			lesion.PatientLevelResult = patientLevelResult;

			List<ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion.ScreenLC_LesionListItem> lesion_lesionList = new List<ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion.ScreenLC_LesionListItem>();
			for (int i = 0; i < _ctx.Length("ScreenLC.Data.Lesion.LesionList.Length"); i++) {
				ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion.ScreenLC_LesionListItem lesionListItem = new ScreenLCResponse.ScreenLC_Data.ScreenLC_Lesion.ScreenLC_LesionListItem();
				lesionListItem.Type = _ctx.StringValue("ScreenLC.Data.Lesion.LesionList["+ i +"].Type");
				lesionListItem.Volume = _ctx.FloatValue("ScreenLC.Data.Lesion.LesionList["+ i +"].Volume");
				lesionListItem.KeySlice = _ctx.LongValue("ScreenLC.Data.Lesion.LesionList["+ i +"].KeySlice");
				lesionListItem.Malignancy = _ctx.FloatValue("ScreenLC.Data.Lesion.LesionList["+ i +"].Malignancy");

				List<string> lesionListItem_recistEndpoints = new List<string>();
				for (int j = 0; j < _ctx.Length("ScreenLC.Data.Lesion.LesionList["+ i +"].RecistEndpoints.Length"); j++) {
					lesionListItem_recistEndpoints.Add(_ctx.StringValue("ScreenLC.Data.Lesion.LesionList["+ i +"].RecistEndpoints["+ j +"]"));
				}
				lesionListItem.RecistEndpoints = lesionListItem_recistEndpoints;

				List<string> lesionListItem_diameter = new List<string>();
				for (int j = 0; j < _ctx.Length("ScreenLC.Data.Lesion.LesionList["+ i +"].Diameter.Length"); j++) {
					lesionListItem_diameter.Add(_ctx.StringValue("ScreenLC.Data.Lesion.LesionList["+ i +"].Diameter["+ j +"]"));
				}
				lesionListItem.Diameter = lesionListItem_diameter;

				lesion_lesionList.Add(lesionListItem);
			}
			lesion.LesionList = lesion_lesionList;
			data.Lesion = lesion;
			screenLCResponse.Data = data;
        
			return screenLCResponse;
        }
    }
}
