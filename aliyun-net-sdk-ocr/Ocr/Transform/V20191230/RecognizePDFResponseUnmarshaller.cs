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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class RecognizePDFResponseUnmarshaller
    {
        public static RecognizePDFResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecognizePDFResponse recognizePDFResponse = new RecognizePDFResponse();

			recognizePDFResponse.HttpResponse = _ctx.HttpResponse;
			recognizePDFResponse.RequestId = _ctx.StringValue("RecognizePDF.RequestId");
			recognizePDFResponse.Code = _ctx.StringValue("RecognizePDF.Code");
			recognizePDFResponse.Message = _ctx.StringValue("RecognizePDF.Message");

			RecognizePDFResponse.RecognizePDF_Data data = new RecognizePDFResponse.RecognizePDF_Data();
			data.Height = _ctx.LongValue("RecognizePDF.Data.Height");
			data.Width = _ctx.LongValue("RecognizePDF.Data.Width");
			data.OrgHeight = _ctx.LongValue("RecognizePDF.Data.OrgHeight");
			data.OrgWidth = _ctx.LongValue("RecognizePDF.Data.OrgWidth");
			data.PageIndex = _ctx.LongValue("RecognizePDF.Data.PageIndex");
			data.Angle = _ctx.LongValue("RecognizePDF.Data.Angle");

			List<RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem> data_wordsInfo = new List<RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem>();
			for (int i = 0; i < _ctx.Length("RecognizePDF.Data.WordsInfo.Length"); i++) {
				RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem wordsInfoItem = new RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem();
				wordsInfoItem.Angle = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].Angle");
				wordsInfoItem.Word = _ctx.StringValue("RecognizePDF.Data.WordsInfo["+ i +"].Word");
				wordsInfoItem.Height = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].Height");
				wordsInfoItem.Width = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].Width");
				wordsInfoItem.X = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].X");
				wordsInfoItem.Y = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].Y");

				List<RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem.RecognizePDF_PositionsItem> wordsInfoItem_positions = new List<RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem.RecognizePDF_PositionsItem>();
				for (int j = 0; j < _ctx.Length("RecognizePDF.Data.WordsInfo["+ i +"].Positions.Length"); j++) {
					RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem.RecognizePDF_PositionsItem positionsItem = new RecognizePDFResponse.RecognizePDF_Data.RecognizePDF_WordsInfoItem.RecognizePDF_PositionsItem();
					positionsItem.X = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].Positions["+ j +"].X");
					positionsItem.Y = _ctx.LongValue("RecognizePDF.Data.WordsInfo["+ i +"].Positions["+ j +"].Y");

					wordsInfoItem_positions.Add(positionsItem);
				}
				wordsInfoItem.Positions = wordsInfoItem_positions;

				data_wordsInfo.Add(wordsInfoItem);
			}
			data.WordsInfo = data_wordsInfo;
			recognizePDFResponse.Data = data;
        
			return recognizePDFResponse;
        }
    }
}
