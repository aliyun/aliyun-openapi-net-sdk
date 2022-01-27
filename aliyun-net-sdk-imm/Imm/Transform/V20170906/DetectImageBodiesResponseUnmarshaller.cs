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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class DetectImageBodiesResponseUnmarshaller
    {
        public static DetectImageBodiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectImageBodiesResponse detectImageBodiesResponse = new DetectImageBodiesResponse();

			detectImageBodiesResponse.HttpResponse = _ctx.HttpResponse;
			detectImageBodiesResponse.RequestId = _ctx.StringValue("DetectImageBodies.RequestId");
			detectImageBodiesResponse.ImageUri = _ctx.StringValue("DetectImageBodies.ImageUri");

			List<DetectImageBodiesResponse.DetectImageBodies_BodiesItem> detectImageBodiesResponse_bodies = new List<DetectImageBodiesResponse.DetectImageBodies_BodiesItem>();
			for (int i = 0; i < _ctx.Length("DetectImageBodies.Bodies.Length"); i++) {
				DetectImageBodiesResponse.DetectImageBodies_BodiesItem bodiesItem = new DetectImageBodiesResponse.DetectImageBodies_BodiesItem();
				bodiesItem.BodyConfidence = _ctx.FloatValue("DetectImageBodies.Bodies["+ i +"].BodyConfidence");

				DetectImageBodiesResponse.DetectImageBodies_BodiesItem.DetectImageBodies_BodyBoundary bodyBoundary = new DetectImageBodiesResponse.DetectImageBodies_BodiesItem.DetectImageBodies_BodyBoundary();
				bodyBoundary.Left = _ctx.IntegerValue("DetectImageBodies.Bodies["+ i +"].BodyBoundary.Left");
				bodyBoundary.Top = _ctx.IntegerValue("DetectImageBodies.Bodies["+ i +"].BodyBoundary.Top");
				bodyBoundary.Width = _ctx.IntegerValue("DetectImageBodies.Bodies["+ i +"].BodyBoundary.Width");
				bodyBoundary.Height = _ctx.IntegerValue("DetectImageBodies.Bodies["+ i +"].BodyBoundary.Height");
				bodiesItem.BodyBoundary = bodyBoundary;

				detectImageBodiesResponse_bodies.Add(bodiesItem);
			}
			detectImageBodiesResponse.Bodies = detectImageBodiesResponse_bodies;
        
			return detectImageBodiesResponse;
        }
    }
}
