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
using Aliyun.Acs.imageaudit.Model.V20191230;

namespace Aliyun.Acs.imageaudit.Transform.V20191230
{
    public class ScanImageResponseUnmarshaller
    {
        public static ScanImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScanImageResponse scanImageResponse = new ScanImageResponse();

			scanImageResponse.HttpResponse = _ctx.HttpResponse;
			scanImageResponse.RequestId = _ctx.StringValue("ScanImage.RequestId");

			ScanImageResponse.ScanImage_Data data = new ScanImageResponse.ScanImage_Data();

			List<ScanImageResponse.ScanImage_Data.ScanImage_Result> data_results = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result>();
			for (int i = 0; i < _ctx.Length("ScanImage.Data.Results.Length"); i++) {
				ScanImageResponse.ScanImage_Data.ScanImage_Result result = new ScanImageResponse.ScanImage_Data.ScanImage_Result();
				result.TaskId = _ctx.StringValue("ScanImage.Data.Results["+ i +"].TaskId");
				result.DataId = _ctx.StringValue("ScanImage.Data.Results["+ i +"].DataId");
				result.ImageURL = _ctx.StringValue("ScanImage.Data.Results["+ i +"].ImageURL");

				List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult> result_subResults = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult>();
				for (int j = 0; j < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults.Length"); j++) {
					ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult subResult = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult();
					subResult.Suggestion = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Suggestion");
					subResult.Rate = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Rate");
					subResult.Label = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Label");
					subResult.Scene = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Scene");

					List<string> subResult_oCRDataList = new List<string>();
					for (int k = 0; k < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].OCRDataList.Length"); k++) {
						subResult_oCRDataList.Add(_ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].OCRDataList["+ k +"]"));
					}
					subResult.OCRDataList = subResult_oCRDataList;

					List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_Frame> subResult_frames = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_Frame>();
					for (int k = 0; k < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Frames.Length"); k++) {
						ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_Frame frame = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_Frame();
						frame.Rate = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Frames["+ k +"].Rate");
						frame.URL = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].Frames["+ k +"].URL");

						subResult_frames.Add(frame);
					}
					subResult.Frames = subResult_frames;

					List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData> subResult_sfaceDataList = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData>();
					for (int k = 0; k < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList.Length"); k++) {
						ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData sfaceData = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData();
						sfaceData.X = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].X");
						sfaceData.Y = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Y");
						sfaceData.Height = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Height");
						sfaceData.Width = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Width");

						List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData.ScanImage_Face> sfaceData_faces = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData.ScanImage_Face>();
						for (int l = 0; l < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Faces.Length"); l++) {
							ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData.ScanImage_Face face = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_SfaceData.ScanImage_Face();
							face.Rate = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Faces["+ l +"].Rate");
							face.Id = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Faces["+ l +"].Id");
							face.Name = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].SfaceDataList["+ k +"].Faces["+ l +"].Name");

							sfaceData_faces.Add(face);
						}
						sfaceData.Faces = sfaceData_faces;

						subResult_sfaceDataList.Add(sfaceData);
					}
					subResult.SfaceDataList = subResult_sfaceDataList;

					List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_HintWordsInfo> subResult_hintWordsInfoList = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_HintWordsInfo>();
					for (int k = 0; k < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].HintWordsInfoList.Length"); k++) {
						ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_HintWordsInfo hintWordsInfo = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_HintWordsInfo();
						hintWordsInfo.Context = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].HintWordsInfoList["+ k +"].Context");

						subResult_hintWordsInfoList.Add(hintWordsInfo);
					}
					subResult.HintWordsInfoList = subResult_hintWordsInfoList;

					List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_LogoData> subResult_logoDataList = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_LogoData>();
					for (int k = 0; k < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList.Length"); k++) {
						ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_LogoData logoData = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_LogoData();
						logoData.Type = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList["+ k +"].Type");
						logoData.X = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList["+ k +"].X");
						logoData.Y = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList["+ k +"].Y");
						logoData.Height = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList["+ k +"].Height");
						logoData.Width = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList["+ k +"].Width");
						logoData.Name = _ctx.StringValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].LogoDataList["+ k +"].Name");

						subResult_logoDataList.Add(logoData);
					}
					subResult.LogoDataList = subResult_logoDataList;

					List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_ProgramCodeData> subResult_programCodeDataList = new List<ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_ProgramCodeData>();
					for (int k = 0; k < _ctx.Length("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].ProgramCodeDataList.Length"); k++) {
						ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_ProgramCodeData programCodeData = new ScanImageResponse.ScanImage_Data.ScanImage_Result.ScanImage_SubResult.ScanImage_ProgramCodeData();
						programCodeData.X = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].ProgramCodeDataList["+ k +"].X");
						programCodeData.Y = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].ProgramCodeDataList["+ k +"].Y");
						programCodeData.Height = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].ProgramCodeDataList["+ k +"].Height");
						programCodeData.Width = _ctx.FloatValue("ScanImage.Data.Results["+ i +"].SubResults["+ j +"].ProgramCodeDataList["+ k +"].Width");

						subResult_programCodeDataList.Add(programCodeData);
					}
					subResult.ProgramCodeDataList = subResult_programCodeDataList;

					result_subResults.Add(subResult);
				}
				result.SubResults = result_subResults;

				data_results.Add(result);
			}
			data.Results = data_results;
			scanImageResponse.Data = data;
        
			return scanImageResponse;
        }
    }
}
