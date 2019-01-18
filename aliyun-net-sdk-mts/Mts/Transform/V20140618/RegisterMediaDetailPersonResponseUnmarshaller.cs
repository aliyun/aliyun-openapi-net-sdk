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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class RegisterMediaDetailPersonResponseUnmarshaller
    {
        public static RegisterMediaDetailPersonResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterMediaDetailPersonResponse registerMediaDetailPersonResponse = new RegisterMediaDetailPersonResponse();

			registerMediaDetailPersonResponse.HttpResponse = context.HttpResponse;
			registerMediaDetailPersonResponse.RequestId = context.StringValue("RegisterMediaDetailPerson.RequestId");

			List<RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_RegisteredPersonage> registerMediaDetailPersonResponse_registeredPersonages = new List<RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_RegisteredPersonage>();
			for (int i = 0; i < context.Length("RegisterMediaDetailPerson.RegisteredPersonages.Length"); i++) {
				RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_RegisteredPersonage registeredPersonage = new RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_RegisteredPersonage();
				registeredPersonage.PersonName = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].PersonName");
				registeredPersonage.FaceId = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].FaceId");
				registeredPersonage.Target = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].Target");
				registeredPersonage.Quality = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].Quality");
				registeredPersonage.Gender = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].Gender");
				registeredPersonage.ImageId = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].ImageId");

				RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_RegisteredPersonage.RegisterMediaDetailPerson_ImageFile imageFile = new RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_RegisteredPersonage.RegisterMediaDetailPerson_ImageFile();
				imageFile.Bucket = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].ImageFile.Bucket");
				imageFile.Location = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].ImageFile.Location");
				imageFile._Object = context.StringValue("RegisterMediaDetailPerson.RegisteredPersonages["+ i +"].ImageFile.Object");
				registeredPersonage.ImageFile = imageFile;

				registerMediaDetailPersonResponse_registeredPersonages.Add(registeredPersonage);
			}
			registerMediaDetailPersonResponse.RegisteredPersonages = registerMediaDetailPersonResponse_registeredPersonages;

			List<RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_FailedImage> registerMediaDetailPersonResponse_failedImages = new List<RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_FailedImage>();
			for (int i = 0; i < context.Length("RegisterMediaDetailPerson.FailedImages.Length"); i++) {
				RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_FailedImage failedImage = new RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_FailedImage();
				failedImage.Code = context.StringValue("RegisterMediaDetailPerson.FailedImages["+ i +"].Code");
				failedImage.Success = context.StringValue("RegisterMediaDetailPerson.FailedImages["+ i +"].Success");

				RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_FailedImage.RegisterMediaDetailPerson_ImageFile1 imageFile1 = new RegisterMediaDetailPersonResponse.RegisterMediaDetailPerson_FailedImage.RegisterMediaDetailPerson_ImageFile1();
				imageFile1.Bucket = context.StringValue("RegisterMediaDetailPerson.FailedImages["+ i +"].ImageFile.Bucket");
				imageFile1.Location = context.StringValue("RegisterMediaDetailPerson.FailedImages["+ i +"].ImageFile.Location");
				imageFile1._Object = context.StringValue("RegisterMediaDetailPerson.FailedImages["+ i +"].ImageFile.Object");
				failedImage.ImageFile1 = imageFile1;

				registerMediaDetailPersonResponse_failedImages.Add(failedImage);
			}
			registerMediaDetailPersonResponse.FailedImages = registerMediaDetailPersonResponse_failedImages;
        
			return registerMediaDetailPersonResponse;
        }
    }
}