//     This code was generated by a Reinforced.Typings tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.

import { IFileModel } from './file.models';

export interface IFrontendSettings
{
	recaptchaSiteKey: string;
	disableUsersRegistration: boolean;
	disableCaptcha: boolean;
	disableImageUploadAnon: boolean;
	disableImageUploadAuth: boolean;
	disableGridUploadAuth: boolean;
}
export interface IImageOwnerModel
{
	guid: string;
	login: string;
	isAnonymous: boolean;
}
export interface IUserModel
{
	guid: string;
	login: string;
	loginNormalized: string;
	createdAt: string;
	roles: string[];
	about: string;
}
export interface IPaginationResponse<T>
{
	skip: number;
	take: number;
	total: number;
	items: T[];
}
export interface IEditImageModel
{
	shortToken: string;
	name?: string;
	description?: string;
}
export interface IImageParsedMetadataModel
{
	width: number;
	height: number;
	tags: IImageParsedMetadataTagModel[];
}
export interface IImageParsedMetadataTagModel
{
	software: string;
	source: string;
	name: string;
	value: string;
}
export interface IImageModel
{
	owner: IImageOwnerModel;
	originalImage: IFileModel;
	compressedImage: IFileModel;
	shortUrl: string;
	shortToken: string;
	deletedAt: string|null;
	createdAt: string;
	name: string;
	description: string;
	parsedMetadata: IImageParsedMetadataModel;
}
export interface IUploadedFileModel
{
	uploaded: boolean;
	reason: string;
	manageToken: string;
	image: IImageModel;
}
export interface IServerErrorResponse
{
	statusCode: number;
	title: string;
	message: string;
	guid: string|null;
	moreData: string;
	innerException: string;
	modelState: { [key:string]: string[] };
}
export enum AudienceType {
	Unknown = 0,
	SdHub = 1
}
export enum CaptchaType {
	ReCaptchaV2 = 0
}
export abstract class ModelStateErrors
{
	public static UserDeleted: string = `USER_DELETED`;
	public static UserNotFound: string = `USER_NOT_FOUND`;
	public static UserEditNotAllowed: string = `USER_EDIT_NOT_ALLOWED`;
	public static UserWithEmailExist: string = `USER_WITH_EMAIL_EXIST`;
	public static UserWithLoginExist: string = `USER_WITH_LOGIN_EXIST`;
	public static UserRegistrationDisabled: string = `USER_REGISTRATION_DISABLED`;
	public static RefreshTokenNotExist: string = `REFRESH_TOKEN_NOT_EXIST`;
	public static EmailNotConfirmed: string = `EMAIL_NOT_CONFIRMED`;
	public static BadCreds: string = `BAD_CREDS`;
	public static BadConfirmationCode: string = `BAD_CONFIRMATION_CODE`;
	public static InvalidCaptcha: string = `INVALID_CAPTCHA`;
	public static ImageNotFound: string = `IMAGE_NOT_FOUND`;
	public static ImageIsPartOfGrid: string = `IMAGE_IS_PART_OF_GRID`;
	public static AlbumNotFound: string = `ALBUM_NOT_FOUND`;
	public static NotAlbumOwner: string = `NOT_ALBUM_OWNER`;
	public static GridNotFound: string = `GRID_NOT_FOUND`;
	public static NotGridOwner: string = `NOT_GRID_OWNER`;
	public static FileNotFound: string = `FILE_NOT_FOUND`;
	public static ModelNotFound: string = `MODEL_NOT_FOUND`;
	public static ModelVersionNotFound: string = `MODEL_VERSION_NOT_FOUND`;
}
