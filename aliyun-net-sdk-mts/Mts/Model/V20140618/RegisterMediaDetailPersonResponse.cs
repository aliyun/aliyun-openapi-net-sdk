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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class RegisterMediaDetailPersonResponse : AcsResponse
	{

		private string requestId;

		private List<RegisterMediaDetailPerson_RegisteredPersonage> registeredPersonages;

		private List<RegisterMediaDetailPerson_FailedImage> failedImages;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<RegisterMediaDetailPerson_RegisteredPersonage> RegisteredPersonages
		{
			get
			{
				return registeredPersonages;
			}
			set	
			{
				registeredPersonages = value;
			}
		}

		public List<RegisterMediaDetailPerson_FailedImage> FailedImages
		{
			get
			{
				return failedImages;
			}
			set	
			{
				failedImages = value;
			}
		}

		public class RegisterMediaDetailPerson_RegisteredPersonage
		{

			private string personName;

			private string faceId;

			private string target;

			private string quality;

			private string gender;

			private string imageId;

			private RegisterMediaDetailPerson_ImageFile imageFile;

			public string PersonName
			{
				get
				{
					return personName;
				}
				set	
				{
					personName = value;
				}
			}

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
				}
			}

			public string Target
			{
				get
				{
					return target;
				}
				set	
				{
					target = value;
				}
			}

			public string Quality
			{
				get
				{
					return quality;
				}
				set	
				{
					quality = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public RegisterMediaDetailPerson_ImageFile ImageFile
			{
				get
				{
					return imageFile;
				}
				set	
				{
					imageFile = value;
				}
			}

			public class RegisterMediaDetailPerson_ImageFile
			{

				private string bucket;

				private string location;

				private string _object;

				public string Bucket
				{
					get
					{
						return bucket;
					}
					set	
					{
						bucket = value;
					}
				}

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string _Object
				{
					get
					{
						return _object;
					}
					set	
					{
						_object = value;
					}
				}
			}
		}

		public class RegisterMediaDetailPerson_FailedImage
		{

			private string code;

			private string success;

			private RegisterMediaDetailPerson_ImageFile1 imageFile1;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Success
			{
				get
				{
					return success;
				}
				set	
				{
					success = value;
				}
			}

			public RegisterMediaDetailPerson_ImageFile1 ImageFile1
			{
				get
				{
					return imageFile1;
				}
				set	
				{
					imageFile1 = value;
				}
			}

			public class RegisterMediaDetailPerson_ImageFile1
			{

				private string bucket;

				private string location;

				private string _object;

				public string Bucket
				{
					get
					{
						return bucket;
					}
					set	
					{
						bucket = value;
					}
				}

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string _Object
				{
					get
					{
						return _object;
					}
					set	
					{
						_object = value;
					}
				}
			}
		}
	}
}