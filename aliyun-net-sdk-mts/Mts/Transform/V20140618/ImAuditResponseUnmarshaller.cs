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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ImAuditResponseUnmarshaller
    {
        public static ImAuditResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ImAuditResponse imAuditResponse = new ImAuditResponse();

			imAuditResponse.HttpResponse = _ctx.HttpResponse;
			imAuditResponse.TextQuotaExceed = _ctx.BooleanValue("ImAudit.TextQuotaExceed");
			imAuditResponse.ImageQuotaExceed = _ctx.BooleanValue("ImAudit.ImageQuotaExceed");
			imAuditResponse.RequestId = _ctx.StringValue("ImAudit.RequestId");

			ImAuditResponse.ImAudit_ImageResults imageResults = new ImAuditResponse.ImAudit_ImageResults();

			List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem> imageResults_result = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem>();
			for (int i = 0; i < _ctx.Length("ImAudit.ImageResults.Result.Length"); i++) {
				ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem resultItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem();
				resultItem.Code = _ctx.LongValue("ImAudit.ImageResults.Result["+ i +"].code");
				resultItem.DataId = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].dataId");
				resultItem.Extras = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].extras");
				resultItem.Msg = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].msg");
				resultItem.TaskId = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].taskId");
				resultItem.Url = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].url");

				List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result> resultItem_results = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result>();
				for (int j = 0; j < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results.Length"); j++) {
					ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result result = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result();
					result.Label = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Label");
					result.Rate = _ctx.DoubleValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Rate");
					result.Scene = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Scene");
					result.Suggestion = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Suggestion");

					List<string> result_qrcodeData = new List<string>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeData.Length"); k++) {
						result_qrcodeData.Add(_ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeData["+ k +"]"));
					}
					result.QrcodeData = result_qrcodeData;

					List<string> result_ocrData = new List<string>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].OcrData.Length"); k++) {
						result_ocrData.Add(_ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].OcrData["+ k +"]"));
					}
					result.OcrData = result_ocrData;

					List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_HintWordsInfoItem> result_hintWordsInfo = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_HintWordsInfoItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].HintWordsInfo.Length"); k++) {
						ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_HintWordsInfoItem hintWordsInfoItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_HintWordsInfoItem();
						hintWordsInfoItem.Context = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].HintWordsInfo["+ k +"].context");

						result_hintWordsInfo.Add(hintWordsInfoItem);
					}
					result.HintWordsInfo = result_hintWordsInfo;

					List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_QrcodeLocationsItem> result_qrcodeLocations = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_QrcodeLocationsItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeLocations.Length"); k++) {
						ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_QrcodeLocationsItem qrcodeLocationsItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_QrcodeLocationsItem();
						qrcodeLocationsItem.X = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeLocations["+ k +"].x");
						qrcodeLocationsItem.Y = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeLocations["+ k +"].y");
						qrcodeLocationsItem.W = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeLocations["+ k +"].w");
						qrcodeLocationsItem.H = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeLocations["+ k +"].h");
						qrcodeLocationsItem.Qrcode = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].QrcodeLocations["+ k +"].qrcode");

						result_qrcodeLocations.Add(qrcodeLocationsItem);
					}
					result.QrcodeLocations = result_qrcodeLocations;

					List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_ProgramCodeDataItem> result_programCodeData = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_ProgramCodeDataItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].ProgramCodeData.Length"); k++) {
						ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_ProgramCodeDataItem programCodeDataItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_ProgramCodeDataItem();
						programCodeDataItem.X = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].ProgramCodeData["+ k +"].x");
						programCodeDataItem.Y = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].ProgramCodeData["+ k +"].y");
						programCodeDataItem.W = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].ProgramCodeData["+ k +"].w");
						programCodeDataItem.H = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].ProgramCodeData["+ k +"].h");

						result_programCodeData.Add(programCodeDataItem);
					}
					result.ProgramCodeData = result_programCodeData;

					List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_LogoDataItem> result_logoData = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_LogoDataItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData.Length"); k++) {
						ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_LogoDataItem logoDataItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_LogoDataItem();
						logoDataItem.Type = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData["+ k +"].type");
						logoDataItem.Name = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData["+ k +"].name");
						logoDataItem.X = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData["+ k +"].x");
						logoDataItem.Y = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData["+ k +"].y");
						logoDataItem.W = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData["+ k +"].w");
						logoDataItem.H = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].LogoData["+ k +"].h");

						result_logoData.Add(logoDataItem);
					}
					result.LogoData = result_logoData;

					List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem> result_sfaceData = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData.Length"); k++) {
						ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem sfaceDataItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem();
						sfaceDataItem.X = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].x");
						sfaceDataItem.Y = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].y");
						sfaceDataItem.W = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].w");
						sfaceDataItem.H = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].h");

						List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem.ImAudit_FacesItem> sfaceDataItem_faces = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem.ImAudit_FacesItem>();
						for (int l = 0; l < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].Faces.Length"); l++) {
							ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem.ImAudit_FacesItem facesItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_SfaceDataItem.ImAudit_FacesItem();
							facesItem.Name = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].Faces["+ l +"].name");
							facesItem.Re = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].Faces["+ l +"].re");
							facesItem.Idid = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].SfaceData["+ k +"].Faces["+ l +"].idid");

							sfaceDataItem_faces.Add(facesItem);
						}
						sfaceDataItem.Faces = sfaceDataItem_faces;

						result_sfaceData.Add(sfaceDataItem);
					}
					result.SfaceData = result_sfaceData;

					List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_FramesItem> result_frames = new List<ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_FramesItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Frames.Length"); k++) {
						ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_FramesItem framesItem = new ImAuditResponse.ImAudit_ImageResults.ImAudit_ResultItem.ImAudit_Result.ImAudit_FramesItem();
						framesItem.Rate = _ctx.FloatValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Frames["+ k +"].rate");
						framesItem.Url = _ctx.StringValue("ImAudit.ImageResults.Result["+ i +"].Results["+ j +"].Frames["+ k +"].url");

						result_frames.Add(framesItem);
					}
					result.Frames = result_frames;

					resultItem_results.Add(result);
				}
				resultItem.Results = resultItem_results;

				imageResults_result.Add(resultItem);
			}
			imageResults.Result = imageResults_result;
			imAuditResponse.ImageResults = imageResults;

			ImAuditResponse.ImAudit_TextResults textResults = new ImAuditResponse.ImAudit_TextResults();

			List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2> textResults_result1 = new List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2>();
			for (int i = 0; i < _ctx.Length("ImAudit.TextResults.Result.Length"); i++) {
				ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2 resultItem2 = new ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2();
				resultItem2.Code = _ctx.LongValue("ImAudit.TextResults.Result["+ i +"].code");
				resultItem2.Content = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].content");
				resultItem2.DataId = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].dataId");
				resultItem2.Msg = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].msg");
				resultItem2.TaskId = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].taskId");

				List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4> resultItem2_results3 = new List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4>();
				for (int j = 0; j < _ctx.Length("ImAudit.TextResults.Result["+ i +"].Results.Length"); j++) {
					ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4 result4 = new ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4();
					result4.Label = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].label");
					result4.Rate = _ctx.DoubleValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].rate");
					result4.Scene = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].scene");
					result4.Suggestion = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].suggestion");

					List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem> result4_details = new List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem>();
					for (int k = 0; k < _ctx.Length("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details.Length"); k++) {
						ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem detailsItem = new ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem();
						detailsItem.Label = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Label");

						List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem.ImAudit_ContextsItem> detailsItem_contexts = new List<ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem.ImAudit_ContextsItem>();
						for (int l = 0; l < _ctx.Length("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts.Length"); l++) {
							ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem.ImAudit_ContextsItem contextsItem = new ImAuditResponse.ImAudit_TextResults.ImAudit_ResultItem2.ImAudit_Result4.ImAudit_DetailsItem.ImAudit_ContextsItem();
							contextsItem.Context = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].context");
							contextsItem.LibName = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].libName");
							contextsItem.LibCode = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].libCode");
							contextsItem.RuleType = _ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].ruleType");

							List<string> contextsItem_positions = new List<string>();
							for (int m = 0; m < _ctx.Length("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].Positions.Length"); m++) {
								contextsItem_positions.Add(_ctx.StringValue("ImAudit.TextResults.Result["+ i +"].Results["+ j +"].Details["+ k +"].Contexts["+ l +"].Positions["+ m +"]"));
							}
							contextsItem.Positions = contextsItem_positions;

							detailsItem_contexts.Add(contextsItem);
						}
						detailsItem.Contexts = detailsItem_contexts;

						result4_details.Add(detailsItem);
					}
					result4.Details = result4_details;

					resultItem2_results3.Add(result4);
				}
				resultItem2.Results3 = resultItem2_results3;

				textResults_result1.Add(resultItem2);
			}
			textResults.Result1 = textResults_result1;
			imAuditResponse.TextResults = textResults;
        
			return imAuditResponse;
        }
    }
}
