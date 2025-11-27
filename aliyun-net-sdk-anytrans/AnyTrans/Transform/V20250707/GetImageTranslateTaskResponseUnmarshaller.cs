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
using Aliyun.Acs.AnyTrans.Model.V20250707;

namespace Aliyun.Acs.AnyTrans.Transform.V20250707
{
    public class GetImageTranslateTaskResponseUnmarshaller
    {
        public static GetImageTranslateTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetImageTranslateTaskResponse getImageTranslateTaskResponse = new GetImageTranslateTaskResponse();

			getImageTranslateTaskResponse.HttpResponse = _ctx.HttpResponse;
			getImageTranslateTaskResponse.Code = _ctx.StringValue("GetImageTranslateTask.code");
			getImageTranslateTaskResponse.Message = _ctx.StringValue("GetImageTranslateTask.message");
			getImageTranslateTaskResponse.RequestId = _ctx.StringValue("GetImageTranslateTask.requestId");
			getImageTranslateTaskResponse.Success = _ctx.BooleanValue("GetImageTranslateTask.success");
			getImageTranslateTaskResponse.HttpStatusCode = _ctx.StringValue("GetImageTranslateTask.httpStatusCode");
			getImageTranslateTaskResponse.Synchro = _ctx.BooleanValue("GetImageTranslateTask.synchro");

			GetImageTranslateTaskResponse.GetImageTranslateTask_Data data = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data();
			data.TraceId = _ctx.StringValue("GetImageTranslateTask.Data.traceId");

			GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation translation = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation();
			translation.Angle = _ctx.LongValue("GetImageTranslateTask.Data.Translation.angle");
			translation.Width = _ctx.LongValue("GetImageTranslateTask.Data.Translation.width");
			translation.Height = _ctx.LongValue("GetImageTranslateTask.Data.Translation.height");
			translation.OrgWidth = _ctx.LongValue("GetImageTranslateTask.Data.Translation.orgWidth");
			translation.OrgHeight = _ctx.LongValue("GetImageTranslateTask.Data.Translation.orgHeight");
			translation.BoxesCount = _ctx.LongValue("GetImageTranslateTask.Data.Translation.boxesCount");

			List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem> translation_boundingBoxes = new List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem>();
			for (int i = 0; i < _ctx.Length("GetImageTranslateTask.Data.Translation.BoundingBoxes.Length"); i++) {
				GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem boundingBoxesItem = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem();
				boundingBoxesItem.Confidence = _ctx.FloatValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].confidence");
				boundingBoxesItem.Text = _ctx.StringValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].text");
				boundingBoxesItem.Direction = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].direction");
				boundingBoxesItem.TableId = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].tableId");
				boundingBoxesItem.TableCellId = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].tableCellId");
				boundingBoxesItem.Translation = _ctx.StringValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].translation");

				GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_UpLeft upLeft = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_UpLeft();
				upLeft.X = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].UpLeft.x");
				upLeft.Y = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].UpLeft.y");
				boundingBoxesItem.UpLeft = upLeft;

				GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_UpRight upRight = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_UpRight();
				upRight.X = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].UpRight.x");
				upRight.Y = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].UpRight.y");
				boundingBoxesItem.UpRight = upRight;

				GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_DownLeft downLeft = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_DownLeft();
				downLeft.X = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].DownLeft.x");
				downLeft.Y = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].DownLeft.y");
				boundingBoxesItem.DownLeft = downLeft;

				GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_DownRight downRight = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_BoundingBoxesItem.GetImageTranslateTask_DownRight();
				downRight.X = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].DownRight.x");
				downRight.Y = _ctx.LongValue("GetImageTranslateTask.Data.Translation.BoundingBoxes["+ i +"].DownRight.y");
				boundingBoxesItem.DownRight = downRight;

				translation_boundingBoxes.Add(boundingBoxesItem);
			}
			translation.BoundingBoxes = translation_boundingBoxes;

			List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem> translation_tableInfos = new List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem>();
			for (int i = 0; i < _ctx.Length("GetImageTranslateTask.Data.Translation.TableInfos.Length"); i++) {
				GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem tableInfosItem = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem();
				tableInfosItem.TableId = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].tableId");
				tableInfosItem.XCellSize = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].xCellSize");
				tableInfosItem.YCellSize = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].yCellSize");

				List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem> tableInfosItem_cellInfos = new List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem>();
				for (int j = 0; j < _ctx.Length("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos.Length"); j++) {
					GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem cellInfosItem = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem();
					cellInfosItem.TableCellId = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].tableCellId");
					cellInfosItem.Text = _ctx.StringValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].text");
					cellInfosItem.Xsc = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].xsc");
					cellInfosItem.Xec = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].xec");
					cellInfosItem.Ysc = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].ysc");
					cellInfosItem.Yec = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].yec");

					List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem.GetImageTranslateTask_PosItem> cellInfosItem_pos = new List<GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem.GetImageTranslateTask_PosItem>();
					for (int k = 0; k < _ctx.Length("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].Pos.Length"); k++) {
						GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem.GetImageTranslateTask_PosItem posItem = new GetImageTranslateTaskResponse.GetImageTranslateTask_Data.GetImageTranslateTask_Translation.GetImageTranslateTask_TableInfosItem.GetImageTranslateTask_CellInfosItem.GetImageTranslateTask_PosItem();
						posItem.X = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].Pos["+ k +"].x");
						posItem.Y = _ctx.LongValue("GetImageTranslateTask.Data.Translation.TableInfos["+ i +"].CellInfos["+ j +"].Pos["+ k +"].y");

						cellInfosItem_pos.Add(posItem);
					}
					cellInfosItem.Pos = cellInfosItem_pos;

					tableInfosItem_cellInfos.Add(cellInfosItem);
				}
				tableInfosItem.CellInfos = tableInfosItem_cellInfos;

				translation_tableInfos.Add(tableInfosItem);
			}
			translation.TableInfos = translation_tableInfos;
			data.Translation = translation;
			getImageTranslateTaskResponse.Data = data;
        
			return getImageTranslateTaskResponse;
        }
    }
}
