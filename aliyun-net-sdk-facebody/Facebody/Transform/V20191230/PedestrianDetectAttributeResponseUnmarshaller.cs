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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class PedestrianDetectAttributeResponseUnmarshaller
    {
        public static PedestrianDetectAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PedestrianDetectAttributeResponse pedestrianDetectAttributeResponse = new PedestrianDetectAttributeResponse();

			pedestrianDetectAttributeResponse.HttpResponse = _ctx.HttpResponse;
			pedestrianDetectAttributeResponse.RequestId = _ctx.StringValue("PedestrianDetectAttribute.RequestId");

			PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data data = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data();
			data.PersonNumber = _ctx.IntegerValue("PedestrianDetectAttribute.Data.PersonNumber");

			List<PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem> data_attributes = new List<PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem>();
			for (int i = 0; i < _ctx.Length("PedestrianDetectAttribute.Data.Attributes.Length"); i++) {
				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem attributesItem = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem();

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Age age = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Age();
				age.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Age.Name");
				age.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Age.Score");
				attributesItem.Age = age;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Backpack backpack = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Backpack();
				backpack.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Backpack.Name");
				backpack.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Backpack.Score");
				attributesItem.Backpack = backpack;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Gender gender = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Gender();
				gender.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Gender.Name");
				gender.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Gender.Score");
				attributesItem.Gender = gender;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Glasses glasses = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Glasses();
				glasses.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Glasses.Name");
				glasses.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Glasses.Score");
				attributesItem.Glasses = glasses;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Handbag handbag = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Handbag();
				handbag.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Handbag.Name");
				handbag.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Handbag.Score");
				attributesItem.Handbag = handbag;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Hat hat = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Hat();
				hat.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Hat.Name");
				hat.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Hat.Score");
				attributesItem.Hat = hat;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_LowerColor lowerColor = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_LowerColor();
				lowerColor.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].LowerColor.Name");
				lowerColor.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].LowerColor.Score");
				attributesItem.LowerColor = lowerColor;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_LowerWear lowerWear = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_LowerWear();
				lowerWear.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].LowerWear.Name");
				lowerWear.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].LowerWear.Score");
				attributesItem.LowerWear = lowerWear;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Orient orient = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_Orient();
				orient.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Orient.Name");
				orient.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].Orient.Score");
				attributesItem.Orient = orient;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_ShoulderBag shoulderBag = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_ShoulderBag();
				shoulderBag.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].ShoulderBag.Name");
				shoulderBag.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].ShoulderBag.Score");
				attributesItem.ShoulderBag = shoulderBag;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_UpperColor upperColor = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_UpperColor();
				upperColor.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].UpperColor.Name");
				upperColor.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].UpperColor.Score");
				attributesItem.UpperColor = upperColor;

				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_UpperWear upperWear = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_AttributesItem.PedestrianDetectAttribute_UpperWear();
				upperWear.Name = _ctx.StringValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].UpperWear.Name");
				upperWear.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Attributes["+ i +"].UpperWear.Score");
				attributesItem.UpperWear = upperWear;

				data_attributes.Add(attributesItem);
			}
			data.Attributes = data_attributes;

			List<PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_BoxesItem> data_boxes = new List<PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_BoxesItem>();
			for (int i = 0; i < _ctx.Length("PedestrianDetectAttribute.Data.Boxes.Length"); i++) {
				PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_BoxesItem boxesItem = new PedestrianDetectAttributeResponse.PedestrianDetectAttribute_Data.PedestrianDetectAttribute_BoxesItem();
				boxesItem.Score = _ctx.FloatValue("PedestrianDetectAttribute.Data.Boxes["+ i +"].Score");
				boxesItem.TopLeftX = _ctx.FloatValue("PedestrianDetectAttribute.Data.Boxes["+ i +"].TopLeftX");
				boxesItem.TopLeftY = _ctx.FloatValue("PedestrianDetectAttribute.Data.Boxes["+ i +"].TopLeftY");
				boxesItem.BottomRightX = _ctx.FloatValue("PedestrianDetectAttribute.Data.Boxes["+ i +"].BottomRightX");
				boxesItem.BottomRightY = _ctx.FloatValue("PedestrianDetectAttribute.Data.Boxes["+ i +"].BottomRightY");

				data_boxes.Add(boxesItem);
			}
			data.Boxes = data_boxes;
			pedestrianDetectAttributeResponse.Data = data;
        
			return pedestrianDetectAttributeResponse;
        }
    }
}
