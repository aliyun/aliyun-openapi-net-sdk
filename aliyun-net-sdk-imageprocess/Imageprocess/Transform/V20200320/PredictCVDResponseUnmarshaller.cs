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
    public class PredictCVDResponseUnmarshaller
    {
        public static PredictCVDResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PredictCVDResponse predictCVDResponse = new PredictCVDResponse();

			predictCVDResponse.HttpResponse = _ctx.HttpResponse;
			predictCVDResponse.RequestId = _ctx.StringValue("PredictCVD.RequestId");
			predictCVDResponse.Code = _ctx.StringValue("PredictCVD.Code");
			predictCVDResponse.Message = _ctx.StringValue("PredictCVD.Message");

			PredictCVDResponse.PredictCVD_Data data = new PredictCVDResponse.PredictCVD_Data();

			PredictCVDResponse.PredictCVD_Data.PredictCVD_Lesion lesion = new PredictCVDResponse.PredictCVD_Data.PredictCVD_Lesion();
			lesion.CVDProbability = _ctx.FloatValue("PredictCVD.Data.Lesion.CVDProbability");

			List<string> lesion_resultURL = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.ResultURL.Length"); i++) {
				lesion_resultURL.Add(_ctx.StringValue("PredictCVD.Data.Lesion.ResultURL["+ i +"]"));
			}
			lesion.ResultURL = lesion_resultURL;

			PredictCVDResponse.PredictCVD_Data.PredictCVD_Lesion.PredictCVD_FeatureScore featureScore = new PredictCVDResponse.PredictCVD_Data.PredictCVD_Lesion.PredictCVD_FeatureScore();

			List<string> featureScore_myoEpiRatio = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.MyoEpiRatio.Length"); i++) {
				featureScore_myoEpiRatio.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.MyoEpiRatio["+ i +"]"));
			}
			featureScore.MyoEpiRatio = featureScore_myoEpiRatio;

			List<string> featureScore_ascAoMaxDiam = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.AscAoMaxDiam.Length"); i++) {
				featureScore_ascAoMaxDiam.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.AscAoMaxDiam["+ i +"]"));
			}
			featureScore.AscAoMaxDiam = featureScore_ascAoMaxDiam;

			List<string> featureScore_coronaryCalciumVol = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.CoronaryCalciumVol.Length"); i++) {
				featureScore_coronaryCalciumVol.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.CoronaryCalciumVol["+ i +"]"));
			}
			featureScore.CoronaryCalciumVol = featureScore_coronaryCalciumVol;

			List<string> featureScore_eatVolume = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.EatVolume.Length"); i++) {
				featureScore_eatVolume.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.EatVolume["+ i +"]"));
			}
			featureScore.EatVolume = featureScore_eatVolume;

			List<string> featureScore_aortaCalciumScore = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.AortaCalciumScore.Length"); i++) {
				featureScore_aortaCalciumScore.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.AortaCalciumScore["+ i +"]"));
			}
			featureScore.AortaCalciumScore = featureScore_aortaCalciumScore;

			List<string> featureScore_cardioThoracicRatio = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.CardioThoracicRatio.Length"); i++) {
				featureScore_cardioThoracicRatio.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.CardioThoracicRatio["+ i +"]"));
			}
			featureScore.CardioThoracicRatio = featureScore_cardioThoracicRatio;

			List<string> featureScore_eatHUMean = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.EatHUMean.Length"); i++) {
				featureScore_eatHUMean.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.EatHUMean["+ i +"]"));
			}
			featureScore.EatHUMean = featureScore_eatHUMean;

			List<string> featureScore_eatHUSTD = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.EatHUSTD.Length"); i++) {
				featureScore_eatHUSTD.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.EatHUSTD["+ i +"]"));
			}
			featureScore.EatHUSTD = featureScore_eatHUSTD;

			List<string> featureScore_rightLungLowattRatio = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.RightLungLowattRatio.Length"); i++) {
				featureScore_rightLungLowattRatio.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.RightLungLowattRatio["+ i +"]"));
			}
			featureScore.RightLungLowattRatio = featureScore_rightLungLowattRatio;

			List<string> featureScore_ascendAortaLength = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.AscendAortaLength.Length"); i++) {
				featureScore_ascendAortaLength.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.AscendAortaLength["+ i +"]"));
			}
			featureScore.AscendAortaLength = featureScore_ascendAortaLength;

			List<string> featureScore_leftLungLowattRatio = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.LeftLungLowattRatio.Length"); i++) {
				featureScore_leftLungLowattRatio.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.LeftLungLowattRatio["+ i +"]"));
			}
			featureScore.LeftLungLowattRatio = featureScore_leftLungLowattRatio;

			List<string> featureScore_deepFeature = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.DeepFeature.Length"); i++) {
				featureScore_deepFeature.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.DeepFeature["+ i +"]"));
			}
			featureScore.DeepFeature = featureScore_deepFeature;

			List<string> featureScore_aortaCalciumVolume = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.AortaCalciumVolume.Length"); i++) {
				featureScore_aortaCalciumVolume.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.AortaCalciumVolume["+ i +"]"));
			}
			featureScore.AortaCalciumVolume = featureScore_aortaCalciumVolume;

			List<string> featureScore_coronaryCalciumScore = new List<string>();
			for (int i = 0; i < _ctx.Length("PredictCVD.Data.Lesion.FeatureScore.CoronaryCalciumScore.Length"); i++) {
				featureScore_coronaryCalciumScore.Add(_ctx.StringValue("PredictCVD.Data.Lesion.FeatureScore.CoronaryCalciumScore["+ i +"]"));
			}
			featureScore.CoronaryCalciumScore = featureScore_coronaryCalciumScore;
			lesion.FeatureScore = featureScore;
			data.Lesion = lesion;
			predictCVDResponse.Data = data;
        
			return predictCVDResponse;
        }
    }
}
