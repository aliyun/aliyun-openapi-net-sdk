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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.lubancloud.Model.V20180509;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.lubancloud.Transform.V20180509
{
    public class BuyOriginPicturesResponseUnmarshaller
    {
        public static BuyOriginPicturesResponse Unmarshall(UnmarshallerContext context)
        {
			BuyOriginPicturesResponse buyOriginPicturesResponse = new BuyOriginPicturesResponse();

			buyOriginPicturesResponse.HttpResponse = context.HttpResponse;
			buyOriginPicturesResponse.RequestId = context.StringValue("BuyOriginPictures.RequestId");

			List<BuyOriginPicturesResponse.BuyOriginPictures_Picture> buyOriginPicturesResponse_pictures = new List<BuyOriginPicturesResponse.BuyOriginPictures_Picture>();
			for (int i = 0; i < context.Length("BuyOriginPictures.Pictures.Length"); i++) {
				BuyOriginPicturesResponse.BuyOriginPictures_Picture picture = new BuyOriginPicturesResponse.BuyOriginPictures_Picture();
				picture.Id = context.LongValue("BuyOriginPictures.Pictures["+ i +"].Id");
				picture.OriginalPictureUrl = context.StringValue("BuyOriginPictures.Pictures["+ i +"].OriginalPictureUrl");

				buyOriginPicturesResponse_pictures.Add(picture);
			}
			buyOriginPicturesResponse.Pictures = buyOriginPicturesResponse_pictures;
        
			return buyOriginPicturesResponse;
        }
    }
}